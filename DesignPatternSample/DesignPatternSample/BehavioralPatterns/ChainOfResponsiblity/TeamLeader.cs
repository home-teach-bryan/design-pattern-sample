namespace DesignPatternSample.BehavioralPatterns.ChainOfResponsiblity;

public class TeamLeader : Leader
{
    public TeamLeader(string name) : base(name)
    {
    }

    public override void HandleRequest(int leaveDays)
    {
        if (leaveDays <= 5)
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