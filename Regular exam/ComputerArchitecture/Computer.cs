using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU cpu = Multiprocessor.FirstOrDefault(x => x.Brand == brand);
            bool isRemoved = Multiprocessor.Remove(cpu);
            return isRemoved;
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(c => c.Frequency).FirstOrDefault();
        }

        public CPU GetCPU(string brand)
        {
            CPU cpu = Multiprocessor.FirstOrDefault(x => x.Brand == brand);
            return cpu;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {Model}:");

            foreach (CPU cpu in Multiprocessor) 
            {
                sb.AppendLine(cpu.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
