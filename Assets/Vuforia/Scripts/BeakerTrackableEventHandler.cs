using UnityEngine;

public class BeakerTrackableEventHandler : DefaultTrackableEventHandler
{
    public Transform cube;

    #region PROTECTED_METHODS
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();

        //cube.GetComponent<Rigidbody>().useGravity = true;
        //cube.GetComponent<Renderer>().enabled = true;
        //cube.GetComponent<Collider>().enabled = true;

        //var rigidComponents = GetComponentsInChildren<Rigidbody>(true);
        //foreach (var component in rigidComponents)
        //    component.useGravity = true;
    }


    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();

        //cube.GetComponent<Rigidbody>().useGravity = false;
        //cube.GetComponent<Renderer>().enabled = false;
        //cube.GetComponent<Collider>().enabled = false;
        //var rigidComponents = GetComponentsInChildren<Rigidbody>(true);
        //foreach (var component in rigidComponents)
        //    component.useGravity = false;
    }

    #endregion // PROTECTED_METHODS
}
