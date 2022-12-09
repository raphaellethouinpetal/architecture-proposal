namespace Xacte.ModuleA.Data.Entities
{
    public sealed class ModuleAEntity
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }
        
        public int MyProperty { get; set; }
        
        public string? WhatsUpWithThatName { get; set; }
    }
}
