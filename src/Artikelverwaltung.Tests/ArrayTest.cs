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
    public class ArrayTest
    {
        private string[] array = new string[3];

        [TestInitialize]
        public void TestInitialize()
        {
            array = new[] {"a", "b", "c"};
        }

        [TestMethod]
        public void GetValueFromExistingIndexReturnsValueAtIndex()
        {
            var result = array[2];

            Assert.AreEqual("c", result);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetValueFromInexistingIndexThrowsException()
        {
            var result = array[15];
        }
    }
}
