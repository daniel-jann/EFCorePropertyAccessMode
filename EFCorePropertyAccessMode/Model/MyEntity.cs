using System;
using JetBrains.Annotations;

namespace EFCorePropertyAccessMode.Model
{
  public class MyEntity
  {
    public MyEntity(Guid keyField1, string keyField2)
    {
      KeyField1 = keyField1;
      KeyField2 = keyField2;
    }

    public Guid KeyField1 { get; [UsedImplicitly] private set; }
    public string KeyField2 { get; [UsedImplicitly] private set; }

    public MyOwnedEntityType MyOwnedEntity
    {
      get => new MyOwnedEntityType(1, "A");
      [UsedImplicitly] private set { }
    }
  }
}