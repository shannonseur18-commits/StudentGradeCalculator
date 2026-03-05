using NUnit.Framework;

[TestFixture]
public class StudentTests
{
    // TEST 1: Average calculates correctly
    [Test]
    public void CalculateAverage_ThreeMarks_ReturnsCorrectAverage()
    {
        // Arrange - your own example: 60 + 75 + 80 = 215 / 3 = 71.6
        Student student = new Student("Shannon", 60, 75, 80);
        // Act
        double average = student.CalculateAverage();
        // Assert
        Assert.That(average, Is.EqualTo(71.6).Within(0.1));
    }

    // TEST 2: Average of 80+ gives grade A
    [Test]
    public void GetGrade_AverageAbove80_ReturnsA()
    {
        // Arrange
        Student student = new Student("Shannon", 80, 85, 90);
        // Act
        string grade = student.GetGrade();
        // Assert
        Assert.That(grade, Is.EqualTo("A"));
    }

    // TEST 3: Average of 70-79 gives grade B
    [Test]
    public void GetGrade_AverageBetween70And79_ReturnsB()
    {
        // Arrange - 60 + 75 + 80 = 71.6 = B
        Student student = new Student("Shannon", 60, 75, 80);
        // Act
        string grade = student.GetGrade();
        // Assert
        Assert.That(grade, Is.EqualTo("B"));
    }

    // TEST 4: Average below 50 gives grade F
    [Test]
    public void GetGrade_AverageBelow50_ReturnsF()
    {
        // Arrange
        Student student = new Student("Shannon", 20, 30, 40);
        // Act
        string grade = student.GetGrade();
        // Assert
        Assert.That(grade, Is.EqualTo("F"));
    }

    // TEST 5: Empty name throws error
    [Test]
    public void Constructor_EmptyName_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Student student = new Student("", 60, 75, 80);
        });
    }

    // TEST 6: Mark above 100 throws error
    [Test]
    public void Constructor_MarkAbove100_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Student student = new Student("Shannon", 110, 75, 80);
        });
    }

    // TEST 7: Negative mark throws error
    [Test]
    public void Constructor_NegativeMark_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Student student = new Student("Shannon", -10, 75, 80);
        });
    }
}
