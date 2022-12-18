using System.Collections.Immutable;
internal class Part
{
    public List<string> myPoemPart;
    public ImmutableList<string>? Poem { get; set; }
    public void AddPart(ImmutableList<string> unfinishedPoem)
    { Poem = unfinishedPoem.AddRange(myPoemPart); }
    public Part()
    { myPoemPart = new List<string>(); }
}
internal class Part1 : Part
{
    public Part1()
    {
        myPoemPart.Add("Вот дом,");
        myPoemPart.Add("Который построил Джек.\n");        
    }
}
internal class Part2 : Part1
{
    public Part2()
    {
        myPoemPart[0] = "А это пшеница,";
        myPoemPart.Insert(1, "Которая в темном чулане хранится");
        myPoemPart.Insert(2, "В доме,");
    }
}
internal class Part3 : Part2
{
    public Part3()
    {
        myPoemPart[0] = "А это веселая птица-синица,";
        myPoemPart.Insert(1, "Которая часто ворует пшеницу,");
    }
}
internal class Part4 : Part3
{
    public Part4()
    {
        myPoemPart[0] = "Вот кот,";
        myPoemPart.Insert(1, "Который пугает и ловит синицу,");
    }
}
internal class Part5 : Part4
{
    public Part5()
    {
        myPoemPart[0] = "Вот пес без хвоста,";
        myPoemPart.Insert(1, "Который за шиворот треплет кота,");
    }
}
internal class Part6 : Part5
{
    public Part6()
    {
        myPoemPart[0] = "А это корова безрогая,";
        myPoemPart.Insert(1, "Лягнувшая старого пса без хвоста,");
    }
}
internal class Part7 : Part6
{
    public Part7()
    {
        myPoemPart[0] = "А это старушка, седая и строгая";
        myPoemPart.Insert(1, "Которая доит корову безрогую,");
    }
}
internal class Part8 : Part7
{
    public Part8()
    {
        myPoemPart[0] = "А это ленивый и толстый пастух,";
        myPoemPart.Insert(1, "Который бранится с коровницей строгою,");
    }
}
internal class Part9 : Part8
{
    public Part9()
    {
        myPoemPart[0] = "Вот два петуха,";
        myPoemPart.Insert(1, "Которые будят того пастуха,");
    }
}