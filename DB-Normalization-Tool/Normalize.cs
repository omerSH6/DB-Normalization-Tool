using System;
using System.Collections.Generic;

namespace DB_Normalization_Tool
{
    public class Normalize
    {
        private List <string> CandidateKey;

        private List <Dependency> FunctionalDependencies;

        private Tuple<string, List<string>> CanonicalFunctionalDependencies;

        private Boolean DependenciesLose;

        private string GenerateCandidateKey()
        {
            return "CandidateKey";
        }
        private Tuple<string, List<string>> GenerateCanonicalFunctionalDependencies()
        {
            return "CandidateKey";
        }

    }
}
