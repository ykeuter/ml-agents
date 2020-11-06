namespace Unity.MLAgents.Sensors
{
    public interface IVariableLengthSensor
    {
        /// <summary>
        /// Returns the size of the observation elements that will be generated.
        /// </summary>
        int[] GetElementShape();

        int GetMaxElements();

        int Write(ObservationWriter writer);

        // Same as ISensor; we might be able to add a common parent interface that defines just these
        void Update();
        void Reset();
        string GetName();
    }
}
