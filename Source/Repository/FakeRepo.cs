using Source.Models;

namespace Source.Repository;

public class FakeRepo
{
    public static List<Student> GetStudents()
    {
        return new()
        {
            new(1, @"", "Nuran", "Huseynova", "Savalan", new DateTime(2022, 10, 5), ParticipationStatus.Present, null, null, null, null),
            new(2, @"avatar1.png", "Huseyn", "Ibrahimov", "Allahverdi", new DateTime(2022, 10, 6), ParticipationStatus.Late, null, null, null, null),
        };
    }
}