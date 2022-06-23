using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Tests.Features.Assessment.Commands
{
    /// <summary>
    /// This class used for test scenario to pass a invalide request data in a test using ClassData
    /// </summary>
    public class GetAssessmentItemsInputInvalideRequest : IEnumerable<object[]>
    {
        /// <summary>
        /// This method used for test scenario in test case (passing blank,empty data)
        /// </summary>
        public static IEnumerable<object[]> GetAssessmentData =>
        new List<object[]>
        {
            new object[] { "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "wdewefeferfrf",new List<string> {},"test","GdssewEEWEE","First" },
            new object[] { "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "",new List<string> { "DEV", "IT" } ,"","",""},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return GetAssessmentData.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            { return GetEnumerator(); }
        }
    }
}