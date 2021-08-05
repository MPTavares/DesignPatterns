namespace Builder
{
    public class RobotBuilder
    {
        private Robot _robot;
        public RobotBuilder()
        {
            _robot = new Robot();
        }
        public RobotBuilder Reset()
        {
            _robot = new Robot();
            return this;
        }
        public RobotBuilder SetName(string name)
        {
            _robot.Name = name;
            return this;
        }
        public RobotBuilder SetPrimaryFunction(string primaryFunction)
        {
            _robot.PrimaryFunction = primaryFunction;
            return this;
        }
        public RobotBuilder AddPart(string partName)
        {
            _robot.Parts.Add(partName);
            return this;
        }
        public Robot Build()
        {
            return _robot;
        }
    }
}