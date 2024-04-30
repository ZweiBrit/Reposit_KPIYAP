using System;

class ParentClass
{
    private int parentField1;
    private string parentField2;

    public ParentClass(int field1, string field2)
    {
        parentField1 = field1;
        parentField2 = field2;
    }

    public int GetParentField1()
    {
        return parentField1;
    }

    public string GetParentField2()
    {
        return parentField2;
    }

    public void DisplayParentFields()
    {
        Console.WriteLine("ParentField1: " + parentField1);
        Console.WriteLine("ParentField2: " + parentField2);
    }
    public void ParentMethod()
    {
        Console.WriteLine("This is a method from the parent class.");
    }
}

class ChildClass : ParentClass
{
    private double childField;

    public ChildClass(int field1, string field2, double field3) : base(field1, field2)
    {
        childField = field3;
    }


    public void DisplayChildField()
    {
        Console.WriteLine("ChildField: " + childField);
    }

    public new void ParentMethod()
    {
        Console.WriteLine("This is a method from the child class.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParentClass parentObj = new ParentClass(10, "ParentField");
        ChildClass childObj = new ChildClass(20, "ParentField", 30.5);

        Console.WriteLine("Base Class:");
        parentObj.DisplayParentFields();
        Console.WriteLine("ParentField1: " + parentObj.GetParentField1());
        Console.WriteLine("ParentField2: " + parentObj.GetParentField2());
        parentObj.ParentMethod();

        Console.WriteLine();

        Console.WriteLine("Derived Class:");
        childObj.DisplayParentFields(); 
        childObj.DisplayChildField(); 
        Console.WriteLine("ParentField1: " + childObj.GetParentField1());
        Console.WriteLine("ParentField2: " + childObj.GetParentField2());
        childObj.ParentMethod();
    }
}
