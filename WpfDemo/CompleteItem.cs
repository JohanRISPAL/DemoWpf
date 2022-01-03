using System;

namespace WpfDemo;

public class CompleteItem
{
    protected Guid _id;
    protected string _name;
    protected int _durability;
    protected string _description;

    public CompleteItem(Guid id, string name, int durability, string description)
    {
        _id = id;
        _name = name;
        _durability = durability;
        _description = description;
    }

    public Guid Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Durability
    {
        get => _durability;
        set => _durability = value;
    }

    public string Description
    {
        get => _description;
        set => _description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return $"Nom : {_name} \nDescription : {_description}\nDurabilité : {_durability} \n";
    }
}