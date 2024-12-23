using C_ASSIGNMENT_BUILDER.Assignment;
using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
namespace C_ASSIGNMENT_BUILDER.Engine;

public class AssignmentList : AssignmentListBase
{
    /* Her legger man inn alle typeof av oppgavene, så guiden kan tracke og følge progresjon. */
    public AssignmentList()
    {
        /* Types skal inneholde en Typeof oppgavesettet man vil tracke. */
        Types = [
            typeof(DiceRollerTest),
            typeof(ReadingData)
        ];
    }
}