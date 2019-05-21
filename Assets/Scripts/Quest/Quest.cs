
[System.Serializable]
public class Quest
{
    //Quest State
    public QuestState state = QuestState.New;
    // Name
    public string name;
    // Description
    public string description;
    // Experience Reward
    public int expReward;
    // Gold Reward
    public int goldReward;
    // Item Reward

    // Goal
    public QuestGoal goal;

    // SourceID
    // QuestID
    // QuestChainID

    // Complete
    public void Complete()
    {
        state = QuestState.Completed;
    }

}
public enum QuestState
{
    New,
    Accepted,
    Failed,
    Completed,
    Claimed
}