using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Decoder_Tryout
{
    public class SpecItem
    {
        public required string Id { get; set; }
        public required int Position { get; set; }
        public required int Length { get; set; }
        public required string Type { get; set; }
        public string? EnumType { get; set; }
    }

    public class BlockSpec
    {
        public List<SpecItem>? Items { get; set; }
    }


    public class DatapointSpec
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required List<SpecItem> Items { get; set; }
        public BlockSpec? Block { get; set; }
    }
    public class EnumValue
    {
        public required string Name { get; set; }
        public required int Value { get; set; }
    }

    public class EnumSpec
    {
        public required string Name { get; set; }
        public required List<EnumValue> Values { get; set; }
    }
}