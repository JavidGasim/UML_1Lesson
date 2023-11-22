
using UML_1Lesson_Part1;
using UML1LessonPart1;

ConcreteBuilder1 b = new ConcreteBuilder1();
Director d = new Director(b);

d.make("");
Product1 p = b.getResult();