using Machine.Specifications;

namespace CodeKataSumStringsasNumbers.Specs
{
    public class When_Adding_UnParsed_Strings_Of_The_Same_Length
    {
        Establish context = () =>
        {
            inputsA = new[] { "1", "3", "6", "11","75","00123", "999999999999999999999999999999999999999999999999999999999999" };
            inputsB = new[] { "5", "2", "9", "73","25","01234", "111111111111111111111111111111111111111111111111111111111111" };
            expectations = new[]
            {
                "6","5","15","84","100","1357","1111111111111111111111111111111111111111111111111111111111110"
            };
            answers = new string[inputsA.Length];
        };

        Because of = () =>
        {
            for (var i = 0; i < inputsA.Length; i++)
            {
                answers[i] = SumStrings.sumStrings(inputsA[i], inputsB[i]);
            }
        };

        It Should_Return_Sum_As_String = () =>
        {
            for (var i = 0; i < answers.Length; i++)
            {
                answers[i].ShouldEqual(expectations[i]);
            }
        };

        private static string[] inputsA;
        private static string[] inputsB;
        private static string[] expectations;
        private static string[] answers;
    }
    public class When_Adding_UnParsed_Strings_Of_Different_Lengths
    {
        Establish context = () =>
        {
            inputsA = new[] { "100", "999","35","928381939495735829874562987469264792740173097034712" };
            inputsB = new[] { "1","1","2000065", "95924075926082458257209502897509247502" };
            expectations = new[] { "101","1000","2000100", "928381939495831753950489069927522002243070606282214" };
            answers = new string[inputsA.Length];
        };

        Because of = () =>
        {
            for (var i = 0; i < inputsA.Length; i++)
            {
                answers[i] = SumStrings.sumStrings(inputsA[i], inputsB[i]);
            }
        };

        It Should_Return_Sum_As_String = () =>
        {
            for (var i = 0; i < answers.Length; i++)
            {
                answers[i].ShouldEqual(expectations[i]);
            }
        };

        private static string[] inputsA;
        private static string[] inputsB;
        private static string[] expectations;
        private static string[] answers;
    }
}