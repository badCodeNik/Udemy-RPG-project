using UnityEngine;

namespace CameraLogic
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform following;
        public float RotationAngleX;
        public float Distance;
        public float OffsetY;

        private void LateUpdate()
        {
            if (following == null)
                return;
            Quaternion rotation = Quaternion.Euler(RotationAngleX, 0, 0);
            Vector3 position = rotation * new Vector3(0, 0, -Distance) + FollowingPointPosition();

            transform.rotation = rotation;
            transform.position = position;
        }

        public void Follow(GameObject followingGameObject)
        {
            following = followingGameObject.transform;
        }

        private Vector3 FollowingPointPosition()
        {
            Vector3 followingPosition = following.position;
            followingPosition.y += OffsetY;
            return followingPosition;
        }
    }
}