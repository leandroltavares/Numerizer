using System;
using System.Collections.Generic;
using Numerizer.Core.Contracts;

namespace Numerizer.Core
{
    public sealed class PTBRDehumanizer : IDehumanizer
    {
        private Dictionary<string, long> cardinalLookup;

        private string[] cardinalPartsDelimiters;

        public PTBRDehumanizer()
        {
            InitializeConstants();
        }

        public long DehumanizeCardinal(string source)
        {
            long output = 0;

            var parts = source.SplitAndKeep(cardinalPartsDelimiters);

            foreach (var part in parts)
            {
                long partValue = 1;

                var elements = part.Split(new[] { " ", " e " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    if (cardinalLookup.ContainsKey(element))
                    {
                        partValue *= cardinalLookup[element];
                    }
                    else
                    {
                        throw new ArgumentException("ERRO");
                    }
                }

                output += partValue;
            }

            return output;
        }

        public long DehumanizeOrdinal(string source)
        {
            throw new NotImplementedException();
        }

        private void InitializeConstants()
        {
            cardinalPartsDelimiters = new string[] { "sextilhoes", "sextilhao", "quintilhoes", "quintilhao", "quadrilhoes", "quadrilhao",
                "trilhoes", "trilhao", "bilhoes", "bilhao", "milhoes", "milhao", "mil "};

            cardinalLookup = new Dictionary<string, long>()
            {
                { "zero", 0},
                { "um", 1 },
                { "dois", 2 },
                { "tres", 3 },
                { "quatro", 4 },
                { "cinco", 5 },
                { "seis", 6 },
                { "sete", 7 },
                { "oito", 8 },
                { "nove", 9 },
                { "dez", 10 },
                { "onze", 11 },
                { "doze", 12 },
                { "treze", 13 },
                //{ "catorze", 14 },
                { "quatorze", 14 },
                { "quinze", 15 },
                { "dezesseis", 16 },
                //{ "dezassete", 17 },
                { "dezessete", 17 },
                { "dezoito", 18 },
                { "dezenove", 19 },
                { "vinte", 20 },
                { "trinta", 30 },
                { "quarenta", 40 },
                { "cinquenta", 50 },
                { "sessenta", 60 },
                { "setenta", 70 },
                { "oitenta", 80 },
                { "noventa", 90 },
                { "cem", 100 },
                { "cento", 100 },
                { "duzentos", 200 },
                { "trezentos", 300 },
                { "quatrocento", 400 },
                { "quinhentos", 500 },
                { "seiscentos", 600 },
                { "setecentos", 700 },
                { "oitocentos", 800 },
                { "novecentos", 900 },
                { "mil", 1000 },
                { "milhao", 1_000_000 },
                { "bilhao", 1_000_000_000 },
                { "trilhao", 1_000_000_000_000 },
                { "quadrilhao", 1_000_000_000_000_000 },
                { "quintilhao", 1_000_000_000_000_000_000 },
                //{ "sextilhao", 1000000000000000000000 }
            };
        }
    }
}
