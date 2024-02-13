using Kreta.Shared.Dtos;
using Kreta.Shared.Parameters;

namespace Kreta.Shared.Extensions
{
    public static class StudentQueryParametersExtension
    {
        public static StudentQueryParametersDto ToDto(this StudentQueryParameters parameters)
        {
            return new StudentQueryParametersDto
            {
                MaxYearOfBirth = parameters.MaxYearOfBirth,
                MinYearOfBirth = parameters.MinYearOfBirth
            };
        }

        public static StudentQueryParameters ToStudentQueryParameters(this StudentQueryParametersDto parameters)
        {
            return new StudentQueryParameters
            {
                MinYearOfBirth = parameters.MinYearOfBirth,
                MaxYearOfBirth = parameters.MaxYearOfBirth
            };
        }
    }
}
