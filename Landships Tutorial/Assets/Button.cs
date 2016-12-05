namespace VRTK
{
    using UnityEngine;

    public class Button : VRTK_InteractableObject
    {
        public float downForce;
        public override void StartUsing(GameObject usingObject)
        {
            base.StartUsing(usingObject);
            Debug.Log("pushed");
            Debug.Log(this.gameObject);
            this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, downForce, 0f), ForceMode.VelocityChange);

        }

        protected override void Start()
        {
            base.Start();
        }
    }
}
