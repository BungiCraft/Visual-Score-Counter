using UnityEngine;

namespace VisualScoreCounter.VSCounter
{
    internal class VSCounterTweenHelper : MonoBehaviour
    {
        public float AnimationTime { get; set; } = 0.20f;
        public EaseType EaseType { get; set; } = EaseType.InExpo;
    }
}
