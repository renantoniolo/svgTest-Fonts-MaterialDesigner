using System;
using System.Collections.Generic;
using Plugin.Iconize;

namespace svgTest
{
    public static class IntegraCollection
    {

        public static IList<IIcon> Icons { get; } = new List<IIcon>();

        static IntegraCollection()
        {
            Icons.Add("icoitg-abastecimento", '\ue90e');
        }
    }
}
