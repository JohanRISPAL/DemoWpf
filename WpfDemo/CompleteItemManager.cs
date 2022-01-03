using System;
using System.Collections.Generic;
using AutoFixture;

namespace WpfDemo;

public class CompleteItemManager
{
    private List<CompleteItem> completeItems = new List<CompleteItem>();
    
    private Fixture fixture = new Fixture();

    public CompleteItemManager()
    {
        completeItems.AddRange(fixture.CreateMany<CompleteItem>(10));
    }

    public List<CompleteItem> CompleteItems
    {
        get => completeItems;
        set => completeItems = value ?? throw new ArgumentNullException(nameof(value));
    }
}