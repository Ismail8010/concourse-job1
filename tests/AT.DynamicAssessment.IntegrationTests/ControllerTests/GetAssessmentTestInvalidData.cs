using System.Collections;
using System.Collections.Generic;


namespace AT.DynamicAssessment.IntegrationTests.ControllerTests;

public class GetAssessmentTestInvalidData : IEnumerable<object[]>
{
    /// <summary>
    /// Return IEnumerable<object[]> for test below scenario in test case (passing blank data, check with other data type)
    ///  assessmentId="",  ctkTakeId="", container=List<string> {},  assessmentTemplate="",  studentId="",  gradeLevel=""
    /// assessmentId="HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk",  ctkTakeId="", container=new List<string> { "DEV", "IT" },  assessmentTemplate="",  studentId="",  gradeLevel=""
    /// assessmentId="HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk",  ctkTakeId="", container=new List<string> { "DEV", "IT" },  assessmentTemplate=1,  studentId=20,  gradeLevel=""
    /// assessmentId="HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk",  ctkTakeId="JJY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", container=new List<string> { "DEV", "IT" },  assessmentTemplate="",  studentId="DDY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk",  gradeLevel="GradeI"
    /// </summary>

    private readonly List<object[]> _data = new List<object[]>
    {
        new object[] { "", "",new List<string> {},"","","" },
        new object[] { "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "",new List<string> { "DEV", "IT" } ,"","",""},
        new object[] { "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "",new List<string> { "DEV", "IT" } ,1,20,""},
        new object[] { "HHY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk", "JJY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk",new List<string> { "DEV", "IT" } ,"","DDY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk","GradeI"},
        new object[] { "", "JJY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk",new List<string> { "DEV", "IT" } ,"DDY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk","DDY0LDE0MSwyNTAsNCwyMDksMjE1LDE3MywxNjk","GradeI"},
    };



    /// <summary>
    ///  implement interface member 'IEnumerable<object[]>.GetEnumerator()
    /// </summary>
    /// <returns></returns>
    public IEnumerator<object[]> GetEnumerator()
    {
        return ((IEnumerable<object[]>)_data).GetEnumerator();
    }

    /// <summary>
    /// implement interface member 'IEnumerable.GetEnumerator()
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
