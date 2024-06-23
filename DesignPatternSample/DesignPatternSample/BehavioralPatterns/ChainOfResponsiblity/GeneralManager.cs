namespace DesignPatternSample.BehavioralPatterns.ChainOfResponsiblity;

public class GeneralManager : Leader
{
    public GeneralManager(string name) : base(name)
    {
    }

    public override void HandleRequest(int leaveDays)
    {
        if (leaveDays <= 10)
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