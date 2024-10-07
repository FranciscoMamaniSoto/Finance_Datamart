public class ScriptMain : UserComponent
{
    float UniqueID = 0;
    float looper = 1;

    public override void Input0_ProcessInputRow(Input0Buffer Row)
    {
        UniqueID = Convert.ToInt32(Variables.HierarchyPathMAX);

        Row.UniqueID = UniqueID + looper;
        looper += 1;
    }
}