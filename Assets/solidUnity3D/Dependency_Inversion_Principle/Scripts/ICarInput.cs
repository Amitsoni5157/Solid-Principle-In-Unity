namespace Dependency_Inversion_Principle
{
    public interface ICarInput
    {
        void ReadInput();
        float Rotation { get; }
        float Thrust { get; }
    }
}