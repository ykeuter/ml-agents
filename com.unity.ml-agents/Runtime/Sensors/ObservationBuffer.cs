using System.Collections.Generic;

namespace Unity.MLAgents.Sensors
{
    public class ObservationBuffer : IVariableLengthSensor
    {
        // Number of floats in the element.
        private int m_ElementSize;
        private int m_MaxElements;

        private List<float[]> m_Observations;

        public ObservationBuffer(int elementSize, int maxElements)
        {
            m_Observations = new List<float[]>(maxElements);
        }

        public void PushObservation(float[] obs)
        {
            if (obs.Length != m_ElementSize)
            {
                throw new UnityAgentsException("Wrong size!");
            }
            // TODO check max elements too.
            m_Observations.Add(obs);
        }

        //
        // IVariableLengthSensor implementation
        //
        public int[] GetElementShape()
        {
            return new[] { m_ElementSize };
        }

        public int GetMaxElements()
        {
            return m_MaxElements;
        }

        public int Write(ObservationWriter writer)
        {
            // TODO
        }

        public void Update()
        {
            m_Observations.Clear();
        }

        public void Reset()
        {
            m_Observations.Clear();
        }

        public string GetName()
        {
            return "ObsBuffer";
        }
    }
}
