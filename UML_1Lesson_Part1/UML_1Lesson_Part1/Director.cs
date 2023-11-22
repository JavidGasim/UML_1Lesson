using UML1LessonPart1;

namespace UML_1Lesson_Part1;

public class Director
{
    private IBuilder builder;

    public Director(IBuilder builder)
    {
        this.builder = builder;
    }

    public void ChangeBuilder(IBuilder builder)
    {

    }

    public void make(string type)
    {
        builder.reset();

        if (type == "simple" )
        {
            builder.buildStepA();
        }

        else
        {
            builder.buildStepB();
            builder.buildStepZ();
        }
    }
}
