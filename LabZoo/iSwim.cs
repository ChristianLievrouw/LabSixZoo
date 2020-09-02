using System;
namespace LabZoo
{
    public interface ISwim
    {
        int SwimSpeed { get; }
        int SwimDistance { get; }
        string Swim();
    }
}
