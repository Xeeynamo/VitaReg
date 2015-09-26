using System;
using System.IO;

namespace VitaReg
{
    public unsafe class Registry
    {
        public struct Header
        {
            uint magiccode;
            ushort verHi;
            ushort verLo;
            fixed uint hash[5];
            uint dataBlocksLength;
            uint dataBlockLength;
            uint dataBlocksCount;
            uint _28;
            uint _2c;
            uint entryLength;
            uint entryTotalLength;
            uint entryOffset;

            public bool IsValid
            {
                get { return magiccode == 0x46524900; }
            }
            public int DataLength
            {
                get { return (int)dataBlocksLength; }
            }
            /// <summary>
            /// How big in bytes is a data block
            /// </summary>
            public int DataBlockLength
            {
                get { return (int)dataBlockLength; }
            }
            public int EntriesCount
            {
                get { return (int)dataBlocksCount; }
            }
            public int EntryTotalLength
            {
                get { return (int)entryTotalLength; }
            }
            public int EntryOffset
            {
                get { return (int)entryOffset; }
            }

            public void Read(BinaryReader reader)
            {
                magiccode = reader.ReadUInt32();
                if (!IsValid)
                    return;
                verHi = reader.ReadUInt16();
                verLo = reader.ReadUInt16();
                fixed (Header *p = &this)
                {
                    p->hash[0] = reader.ReadUInt32();
                    p->hash[1] = reader.ReadUInt32();
                    p->hash[2] = reader.ReadUInt32();
                    p->hash[3] = reader.ReadUInt32();
                    p->hash[4] = reader.ReadUInt32();
                }
                dataBlocksLength = reader.ReadUInt32();
                dataBlockLength = reader.ReadUInt32();
                dataBlocksCount = reader.ReadUInt32();
                _28 = reader.ReadUInt32(); // 652
                _2c = reader.ReadUInt32(); // 128
                entryLength = reader.ReadUInt32();
                entryTotalLength = reader.ReadUInt32();
                entryOffset = reader.ReadUInt32();
            }
            public void Write(BinaryWriter writer)
            {

            }
            private void ReadHash(BinaryReader reader)
            {

            }
        }
        public struct IndexEntry
        {
            public ushort _00;
            public ushort _02;
            public ushort parent;
            public ushort _06;
            public ushort _08;
            public ushort activeEntries;
            ushort blocksCount;
            fixed char name[28];
            public ushort _28;
            fixed ushort blockOffset[7];
            public ushort _38;

            public string Name
            {
                get
                {
                    fixed (IndexEntry* e = &this)
                    {
                        return new string(e->name);
                    }
                }
            }
            public int BlocksCount
            {
                get { return blocksCount; }
            }

            public int GetBlockOffset(int index)
            {
                fixed (IndexEntry *p = &this)
                    return p->blockOffset[index];
            }

            public void Read(BinaryReader reader)
            {
                _00 = reader.ReadUInt16();
                _02 = reader.ReadUInt16();
                parent = reader.ReadUInt16();
                _06 = reader.ReadUInt16();
                _08 = reader.ReadUInt16();
                activeEntries = reader.ReadUInt16();
                blocksCount = reader.ReadUInt16();
                fixed (IndexEntry* e = &this)
                    for (int i = 0; i < 28; i++)
                        e->name[i] = (char)reader.ReadByte();
                _28 = reader.ReadUInt16();
                fixed (IndexEntry* e = &this)
                    for (int i = 0; i < 7; i++)
                        e->blockOffset[i] = reader.ReadUInt16();
                _38 = reader.ReadUInt16();
            }
            public void Write(BinaryWriter writer)
            {
                writer.Write(_00);
                writer.Write(_02);
                writer.Write(parent);
                writer.Write(_06);
                writer.Write(_08);
                writer.Write(activeEntries);
                writer.Write(blocksCount);
                fixed (IndexEntry* e = &this)
                    for (int i = 0; i < 28; i++)
                        writer.Write((byte)e->name[i]);
                writer.Write(_28);
                fixed (IndexEntry* e = &this)
                    for (int i = 0; i < 28; i++)
                        writer.Write(e->blockOffset[i]);
                writer.Write(_38);
            }
        }
        public class Entry
        {
            Header h;
            IndexEntry e;
            ushort _00;
            ushort _02;
            ushort offset; // where values are located
            ushort _06;
            ushort _08;
            ushort _0a;
            ushort count; // how values there are; NO!
            int activeEntries;

            public Header Parent
            { get { return h; } }
            public int Count
            {
                get { return activeEntries; }
            }
            public int StartOffset
            {
                get
                {
                    if (e.BlocksCount == 0)
                        return 0;
                    return e.GetBlockOffset(0) * h.DataBlockLength;
                }
            }

            byte[] data;
            Value[] value;
            public Entry(Header h, IndexEntry e, Stream stream)
            {
                this.h = h;
                this.e = e;
                data = new byte[h.DataBlockLength * e.BlocksCount];
                for (int i = 0; i < e.BlocksCount; i++)
                {
                    stream.Position = e.GetBlockOffset(i) * h.DataBlockLength;
                    stream.Read(data, h.DataBlockLength * i, h.DataBlockLength);
                }
                BinaryReader reader = new BinaryReader(new MemoryStream(data));
                _00 = reader.ReadUInt16();
                _02 = reader.ReadUInt16();
                offset = reader.ReadUInt16();
                _06 = reader.ReadUInt16();
                _08 = reader.ReadUInt16();
                _0a = reader.ReadUInt16();
                count = reader.ReadUInt16();
                
                reader.BaseStream.Position = offset;
                value = new Value[activeEntries = e.activeEntries];
                for (int i = 0; i < value.Length; i++)
                    value[i] = new Value(reader, this, i);
            }
            public Value GetValue(int index)
            {
                return value[index];
            }
        }
        public class Value
        {
            struct ValuePointer
            {
                public ushort length;
                public byte unk;
                public byte block;
                public void Read(BinaryReader reader)
                {
                    length = reader.ReadUInt16();
                    unk = reader.ReadByte();
                    block = reader.ReadByte();
                }
            }
            public enum Type
            {
                Registry = 1,
                Integer = 2,
                String = 3,
                Data = 4,
            }
            Entry parent;
            int index;
            Type type;
            string name;
            public Entry Parent
            { get { return parent; } }
            public int Index
            { get { return index; } }
            public Type CurrentType
            { get { return type; } }
            public string Name
            { get { return name; } }

            public int ValueRegistry;
            public int ValueInteger;
            public string ValueString;
            public byte[] ValueData;

            public Value(BinaryReader reader, Entry parent, int index)
            {
                this.parent = parent;
                this.index = index;
                type = (Type)reader.ReadByte();
                char[] strData = new char[0x1B];
                for (int i = 0; i < strData.Length; i++)
                    strData[i] = (char)reader.ReadByte();
                name = new string(strData);
                switch (type)
                {
                    case Type.Registry:
                        ValueRegistry = reader.ReadInt32();
                        break;
                    case Type.Integer:
                        ValueInteger = reader.ReadInt32();
                        break;
                    case Type.String:
                        {
                            ValuePointer p = new ValuePointer();
                            p.Read(reader);
                            long prevOff = reader.BaseStream.Position;
                            reader.BaseStream.Position = p.block * 0x20;
                            char[] str = new char[p.length];
                            for (int i = 0; i < str.Length; i++)
                                str[i] = (char)reader.ReadByte();
                            ValueString = new string(str);
                            reader.BaseStream.Position = prevOff;
                        }
                        break;
                    case Type.Data:
                        {
                            ValuePointer p = new ValuePointer();
                            p.Read(reader);
                            long prevOff = reader.BaseStream.Position;
                            reader.BaseStream.Position = p.block * 0x20;
                            ValueData = new byte[p.length];
                            for (int i = 0; i < ValueData.Length; i++)
                                ValueData[i] = reader.ReadByte();
                            reader.BaseStream.Position = prevOff;
                        }
                        break;
                }
            }
        }

        Header header;
        IndexEntry[] ientry;
        Entry[] entry;

        public Registry(string name)
        {
            Open(new FileStream(name + ".ireg", FileMode.Open),
                new FileStream(name + ".dreg", FileMode.Open));
        }
        public Registry(Stream iStream, Stream dStream)
        {
            Open(iStream, dStream);
        }
        private void Open(Stream iStream, Stream dStream)
        {
            BinaryReader reader = new BinaryReader(iStream);
            header.Read(reader);
            if (header.IsValid)
            {
                reader.BaseStream.Position = header.EntryOffset;
                ientry = new IndexEntry[header.EntriesCount];
                for (int i = 0; i < ientry.Length; i++)
                    ientry[i].Read(reader);
                entry = new Entry[ientry.Length];
                for (int i = 0; i < ientry.Length; i++)
                {
                    if (ientry[i].BlocksCount > 0)
                        entry[i] = new Entry(header, ientry[i], dStream);
                    else
                        entry[i] = null;
                }
            }
            iStream.Close();
            dStream.Close();
        }
        public bool IsValid
        {
            get { return header.IsValid; }
        }
        public Header CurrentHeader
        { get { return header; } }
        public IndexEntry GetEntryDesc(int index)
        {
            return ientry[index];
        }
        public Entry GetEntry(int index)
        {
            if (!header.IsValid)
                return null;
            return entry[index];
        }
    }
}
