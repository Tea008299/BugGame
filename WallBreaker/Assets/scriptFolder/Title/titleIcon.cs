using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

namespace Spine.Unity.Examples
{
    public class Titleicon : MonoBehaviour
    {
        SkeletonAnimation SkeltonAnim;

        // Use this for initialization
        void Start()
        {
             SkeltonAnim = GetComponent<SkeletonAnimation>();
            SkeltonAnim.state.SetAnimation(0, "rotain4", true);
            SkeltonAnim.state.SetAnimation(1, "rotain6", true);
            SkeltonAnim.state.SetAnimation(2, "rotain9", true);
            SkeltonAnim.state.SetAnimation(3, "rotain10", true);
            SkeltonAnim.state.SetAnimation(4, "rotain11", true);
            SkeltonAnim.state.SetAnimation(5, "rotain12", true);


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
