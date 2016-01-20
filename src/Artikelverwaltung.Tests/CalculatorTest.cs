/**
 * Copyright 2016 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Artikelverwaltung.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator _calculator = new Calculator();

        [TestMethod]
        public void SumWithTwoPositiveNumbersReturnsCorrectResult()
        {
            long result = _calculator.Sum(5, 6);
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void SumWithTwoNegativeNumbersReturnsCorrectResult()
        {
            long result = _calculator.Sum(-5, -6);
            Assert.AreEqual(-11, result);
        }

        [TestMethod]
        public void SumWithANegativeNumberAndPositiveNumberReturnsCorrectResult()
        {
            long result = _calculator.Sum(-5, 6);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SumReturnsCorrectResult()
        {
            for (int i = 0; i < 10000; i ++)
            {
                long result = _calculator.Sum(i, i);
                Assert.AreEqual(2 * i, result);
            }
        }
    }
}
