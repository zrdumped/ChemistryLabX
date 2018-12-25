using UnityEngine;

public class BeakerTrackableEventHandler : DefaultTrackableEventHandler
{
    #region PROTECTED_METHODS

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        var rigidComponents = GetComponentsInChildren<Rigidbody>(true);
        foreach (var component in rigidComponents)
            component.useGravity = true;
    }


    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();

        var rigidComponents = GetComponentsInChildren<Rigidbody>(true);
        foreach (var component in rigidComponents)
            component.useGravity = false;
    }

    #endregion // PROTECTED_METHODS
}
