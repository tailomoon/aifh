// Artificial Intelligence for Humans
// Volume 2: Nature-Inspired Algorithms
// C# Version
// http://www.aifh.org
// http://www.jeffheaton.com
//
// Code repository:
// https://github.com/jeffheaton/aifh
//
// Copyright 2014 by Jeff Heaton
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// For more information on Heaton Research copyrights, licenses
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
using AIFH_Vol2.Core.Evolutionary.Species;
using AIFH_Vol2.Core.Evolutionary.Train;
using System.Collections.Generic;

namespace AIFH_Vol2.Core.Evolutionary.Sort
{
    /// <summary>
    ///     This comparator is used to compare two species. This is done by comparing the
    ///     scores of the two leaders.
    /// </summary>
    public class SpeciesComparer : Comparer<ISpecies>
    {
        /// <summary>
        ///     The training method.
        /// </summary>
        private readonly IEvolutionaryAlgorithm _training;

        /// <summary>
        ///     Create a species comparator.
        /// </summary>
        /// <param name="theTraining">The trainer.</param>
        public SpeciesComparer(IEvolutionaryAlgorithm theTraining)
        {
            _training = theTraining;
        }

        /// <inheritdoc />
        public override int Compare(ISpecies sp1, ISpecies sp2)
        {
            return _training.BestComparer.Compare(sp1.Leader,
                                                 sp2.Leader);
        }
    }
}
