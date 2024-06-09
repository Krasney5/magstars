using Player;

namespace Triggers
{
    public class MapTrigger : Trigger<Backpack>
    {
        protected override void OnStay(Backpack triggered)
        {
            triggered.Grab(gameObject);
        }
    }
}
