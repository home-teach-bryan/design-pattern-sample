namespace DesignPatternSample.BehavioralPatterns.ChainOfResponsiblity;

public class Director : Leader
{
    public Director(string name) : base(name)
    {
    }

    public override void HandleRequest(int leaveDays)
    {
        if (leaveDays <= 7)
        {
            this.LeaveApproved(leaveDays);
        }
        else
        {
            var nextLevel = GetNext();
            if (nextLevel != null)
            {
                nextLevel.HandleRequest(leaveDays);
            }
            else
            {
                this.LeaveFailed();
            }
        }
    }
}