using System;

namespace ShapeAndGroup
{
    public class GroupMeasure : IMeasure
    {
        IOperator operatorr;

        public GroupMeasure(IOperator operat)
        {
            this.operatorr = operat;
        }
        public double GetResult(IMeasurable group)
        {
            var groupM = group as ShapeGroup<IMeasurable>;
            if (groupM == null) new ArgumentException();
            double result = 0;
            foreach (var t in groupM)
            {
                result = operatorr.DoAction(t.GetMeasure(), result);
            }
            return result;
        }
    }
}
