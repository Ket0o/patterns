namespace File_system_Composite_;

abstract class Component
{
    protected readonly string Name;
    
    protected Component(string name)
    {
        Name = name;
    }

    public virtual void Add(Component component)
    {
    }

    public virtual void Remove(Component component)
    {
    }

    public virtual void Print()
    {
        Console.WriteLine(Name);
    }
}
class Directory : Component
{
    private readonly List<Component> _components = new();
    
    public Directory(string name): base(name) {}

    public override void Add(Component component)
    {
        _components.Add(component);
    }

    public override void Remove(Component component)
    {
        _components.Remove(component);
    }

    public override void Print()
    {
        Console.WriteLine("Узел: " + Name);
        Console.WriteLine("Подузлы:");
        for (int i = 0; i < _components.Count; i++)
        {
            _components[i].Print();
        }
    }
}

class File : Component
{
    public File(string name)
        : base(name)
    { }
}

class Program
{
    static void Main(string[] args)
    {
        Component fileSystem = new Directory("Файловая система");
        // определяем новый диск
        Component diskC = new Directory("Диск С");
        // новые файлы
        Component pngFile = new File("12345.png");
        Component docxFile = new File("Document.docx");
        // добавляем файлы на диск С
        diskC.Add(pngFile);
        diskC.Add(docxFile);
        // добавляем диск С в файловую систему
        fileSystem.Add(diskC);
        // выводим все данные
        fileSystem.Print();
        Console.WriteLine();
        fileSystem.Print();
        Console.WriteLine();
        //удаляем с диска С файл
        diskC.Remove(pngFile);
        // создаем новую папку
        Component docsFolder = new Directory("Мои Документы");
        // добавляем в нее файлы
        Component txtFile = new File("readme.txt");
        Component csFile = new File("Program.cs");
        docsFolder.Add(txtFile);
        docsFolder.Add(csFile);
        diskC.Add(docsFolder);

        fileSystem.Print();

        Console.WriteLine();

        pngFile.Print();

        Console.Read();
    }
}