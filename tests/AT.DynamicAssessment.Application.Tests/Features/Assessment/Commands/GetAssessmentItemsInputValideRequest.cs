using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AT.DynamicAssessment.Application.Tests.Features.Assessment.Commands
{
    /// <summary>
    /// This class used for test scenario to pass a valide request data in a test using ClassData
    /// </summary>
    public class GetAssessmentItemsInputValideRequest : IEnumerable<object[]>
    {
        /// <summary>
        /// This method used for test scenario in test case (passing requird data)
        /// </summary>
        public static IEnumerable<object[]> GetAssessmentValideData =>
        new List<object[]>
        {
             new object[] { "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "MMMrtrtTMSwyNTAsNCwyMDksMjE97665DE3MywxNjk",new List<string> {"container1","container2"},"test","GK34434fgfff","Second" },
            new object[] { "KKRR0es0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "PPP54rr0MSwyNTA334fgfgyMDksMjE1LDE3MywxNjk",new List<string> { "DEV", "IT" } ,"test2","GdssewEEWEE","First"},
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return GetAssessmentValideData.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            { return GetEnumerator(); }
        }
    }
}