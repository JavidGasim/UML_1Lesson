using UML_1Lesson_Part1;

namespace UML1LessonPart1;

public interface IBuilder
{
    public void reset();
    public void buildStepA();
    public void buildStepB();
    public void buildStepZ();
}

public class ConcreteBuilder1: IBuilder
{
    Product1 result;

    public void buildStepA()
    {
        throw new NotImplementedException();
    }

    public void buildStepB()
    {
        throw new NotImplementedException();
    }

    public void buildStepZ()
    {
        throw new NotImplementedException();
    }

    public void reset()
    {
        result = new Product1();
    }

    public Product1 getResult()
    {
        return this.result;
    }
}

public class ConcreteBuilder2 : IBuilder
{
    Product2 result;

    public void buildStepA()
    {
        throw new NotImplementedException();
    }

    public void buildStepB()
    {
        throw new NotImplementedException();
    }

    public void buildStepZ()
    {
        throw new NotImplementedException();
    }

    public void reset()
    {
        result = new Product2();
    }

    public Product2 getResult()
    {
        return this.result;
    }
}