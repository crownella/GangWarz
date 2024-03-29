//%GenSrc:1:uwiErlMF00601FVXlizvHw
//%CodeKey:6RElrnj8VkWhTGgEn/tpVA
/*
 * This code was generated by InstinctAI
 *
 *         DO NOT MODIFY BY HAND
 *     THIS FILE WILL BE REGENERATED
 *
 *      DO NOT REMOVE/EDIT COMMENTS
 *
 * If you do need to modify this file, note that it is a partial class.
 * See https://msdn.microsoft.com/en-us/library/wa80x488.aspx
 * You can edit the file GangLeaderBehavior.cs
 */

namespace instinctai.usr.behaviours
{
    using System.Collections;
    using UnityEngine;
    using com.kupio.instinctai;
#if UNITY_EDITOR
    using UnityEditor;
    using com.kupio.instinctai.live;
#endif


    public partial class GangLeaderBehavior : MonoBehaviour
#if UNITY_EDITOR
        , LiveTree
#endif
    {
        private IEnumerator _state = null;

        private int _jmp;
        private bool valid = true;





#if UNITY_EDITOR
    private LiveUpdate _live;
    private int _liveHandle;
#endif


        void FixedUpdate()
        {
            if (valid) {
                if (_state == null || _state.MoveNext() == false) {
                    _state = StateGen();
                    _state.MoveNext();
                }
            }
        }

        private IEnumerator StateGen()
        {
            int node = 0;
            NodeVal ret = NodeVal.Error;
            _jmp = -1;

            int n0c = -1;
            int n10c = -1;
            int n11c = -1;
            int n2c = -1;
            int n31c = -1;
            int n32c = -1;
            int n35c = -1;
            int n36c = -1;
            int n3c = -1;
            int n4c = -1;
            int n6c = -1;
            int n7c = -1;
            int n8c = -1;
            NodeVal n0_1r = NodeVal.Invalid;
            NodeVal n10_1r = NodeVal.Invalid;
            NodeVal n11_1r = NodeVal.Invalid;
            NodeVal n3_1r = NodeVal.Invalid;
            NodeVal n35_1r = NodeVal.Invalid;
            NodeVal n36_1r = NodeVal.Invalid;
            NodeVal n4_1r = NodeVal.Invalid;
            NodeVal n7_1r = NodeVal.Invalid;
            NodeVal n8_1r = NodeVal.Invalid;
            Vector3 v1 = Vector3.zero;


            if (!valid) {
                throw new BehaviourTreeException("Behaviour tree will not run. The GameObject has missing required components.");
            }

            do {
                switch (node) {
                    case 0:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(43, _liveHandle, NodeVal.Running, false, true);
                        #endif
                        n0c = 1;
                        node = 1;
                        n0_1r = NodeVal.Success;
                        break;
                    case 45:

                        if (_jmp >= 0) {
                            node = _jmp;
                            _jmp = -1;
                            continue;
                        }
                        n0_1r = (NodeVal)System.Math.Max((int)n0_1r, (int)ret);
                        if (ret == NodeVal.Success && n0c < 2) {
                            node = ++n0c;
                        } else {
                            n0c = 1;
                            node = 0;
                            ret = n0_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(43, _liveHandle, ret, true, false);
                        #endif
                            yield return null;
                        }
                        break;
                    case 1:

                        ret = (!this.inFight)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(45, _liveHandle, ret, false, false);
                        #endif
                        node = 45;
                        break;
                    case 2:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(44, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n2c = 3;
                        node = 3;
                        break;
                    case 47:

                        if(ret != NodeVal.Success) {
                            if (++n2c > 4) {
                                n2c = 3;
                                node = 45;
                            } else {
                                node = n2c;
                            }
                        } else {
                            n2c = 3;
                            node = 45;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(44, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 3:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(1, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n3c = 5;
                        node = 5;
                        n3_1r = NodeVal.Success;
                        break;
                    case 48:

                        n3_1r = (NodeVal)System.Math.Max((int)n3_1r, (int)ret);
                        if (ret == NodeVal.Success && n3c < 6) {
                            node = ++n3c;
                        } else {
                            n3c = 5;
                            node = 47;
                            ret = n3_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(1, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 4:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(0, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n4c = 30;
                        node = 30;
                        n4_1r = NodeVal.Success;
                        break;
                    case 49:

                        n4_1r = (NodeVal)System.Math.Max((int)n4_1r, (int)ret);
                        if (ret == NodeVal.Success && n4c < 32) {
                            node = ++n4c;
                        } else {
                            n4c = 30;
                            node = 47;
                            ret = n4_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(0, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 5:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(2, _liveHandle, ret, false, false);
                        #endif
                        node = 48;
                        break;
                    case 6:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(25, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n6c = 7;
                        node = 7;
                        break;
                    case 51:

                        if(ret != NodeVal.Success) {
                            if (++n6c > 8) {
                                n6c = 7;
                                node = 48;
                            } else {
                                node = n6c;
                            }
                        } else {
                            n6c = 7;
                            node = 48;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(25, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 7:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(26, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n7c = 9;
                        node = 9;
                        n7_1r = NodeVal.Success;
                        break;
                    case 52:

                        n7_1r = (NodeVal)System.Math.Max((int)n7_1r, (int)ret);
                        if (ret == NodeVal.Success && n7c < 11) {
                            node = ++n7c;
                        } else {
                            n7c = 9;
                            node = 51;
                            ret = n7_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(26, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 8:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(13, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n8c = 24;
                        node = 24;
                        n8_1r = NodeVal.Success;
                        break;
                    case 53:

                        n8_1r = (NodeVal)System.Math.Max((int)n8_1r, (int)ret);
                        if (ret == NodeVal.Success && n8c < 29) {
                            node = ++n8c;
                        } else {
                            n8c = 24;
                            node = 51;
                            ret = n8_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(13, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 9:

                        ret = (this.hasMin)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(27, _liveHandle, ret, false, false);
                        #endif
                        node = 52;
                        break;
                    case 10:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(28, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n10c = 12;
                        node = 12;
                        n10_1r = NodeVal.Success;
                        break;
                    case 55:

                        n10_1r = (NodeVal)System.Math.Max((int)n10_1r, (int)ret);
                        if (ret == NodeVal.Success && n10c < 17) {
                            node = ++n10c;
                        } else {
                            n10c = 12;
                            node = 52;
                            ret = n10_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(28, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 11:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(35, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n11c = 18;
                        node = 18;
                        n11_1r = NodeVal.Success;
                        break;
                    case 56:

                        n11_1r = (NodeVal)System.Math.Max((int)n11_1r, (int)ret);
                        if (ret == NodeVal.Success && n11c < 23) {
                            node = ++n11c;
                        } else {
                            n11c = 18;
                            node = 52;
                            ret = n11_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(35, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 12:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(29, _liveHandle, ret, false, false);
                        #endif
                        node = 55;
                        break;
                    case 13:


                        do
                        {
                            ret = (this.FindPlayer());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(30, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 55;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(30, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 14:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(31, _liveHandle, ret, false, false);
                        #endif
                        node = 55;
                        break;
                    case 15:


                        do
                        {
                            ret = (this.Wander());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(32, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 55;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(32, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 16:


                        do
                        {
                                v1 = this.direction;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 3f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(33, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 55;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(33, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 17:


                        do
                        {
                            ret = (this.FindPlayer());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(34, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 55;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(34, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 18:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(36, _liveHandle, ret, false, false);
                        #endif
                        node = 56;
                        break;
                    case 19:


                        do
                        {
                            ret = (this.FindMember());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(37, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 56;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(37, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 20:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(38, _liveHandle, ret, false, false);
                        #endif
                        node = 56;
                        break;
                    case 21:


                        do
                        {
                            ret = (this.Wander());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(39, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 56;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(39, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 22:


                        do
                        {
                                v1 = this.direction;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 3f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(40, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 56;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(40, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 23:


                        do
                        {
                            ret = (this.FindMember());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(41, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 56;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(41, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 24:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(8, _liveHandle, ret, false, false);
                        #endif
                        node = 53;
                        break;
                    case 25:


                        do
                        {
                            ret = (this.FindMember());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(9, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 53;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(9, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 26:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(7, _liveHandle, ret, false, false);
                        #endif
                        node = 53;
                        break;
                    case 27:


                        do
                        {
                            ret = (this.Wander());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(10, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 53;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(10, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 28:


                        do
                        {
                                v1 = this.direction;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 3f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(11, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 53;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(11, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 29:


                        do
                        {
                            ret = (this.FindMember());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(12, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 53;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(12, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 30:

                        ret = (!this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(3, _liveHandle, ret, false, false);
                        #endif
                        node = 49;
                        break;
                    case 31:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(4, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n31c = 33;
                        node = 33;
                        break;
                    case 76:

                        if(ret != NodeVal.Success) {
                            if (++n31c > 34) {
                                n31c = 33;
                                node = 49;
                            } else {
                                node = n31c;
                            }
                        } else {
                            n31c = 33;
                            node = 49;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(4, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 32:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(17, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n32c = 35;
                        node = 35;
                        break;
                    case 77:

                        if(ret != NodeVal.Success) {
                            if (++n32c > 36) {
                                n32c = 35;
                                node = 49;
                            } else {
                                node = n32c;
                            }
                        } else {
                            n32c = 35;
                            node = 49;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(17, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 33:

                        ret = ((transform.position - (this.targetLocation).position).sqrMagnitude < (0.25f))? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(5, _liveHandle, ret, false, false);
                        #endif
                        node = 76;
                        break;
                    case 34:


                        do
                        {
                                v1 = (this.targetLocation).position;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 3f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(6, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 76;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(6, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 35:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(23, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n35c = 37;
                        node = 37;
                        n35_1r = NodeVal.Success;
                        break;
                    case 80:

                        n35_1r = (NodeVal)System.Math.Max((int)n35_1r, (int)ret);
                        if (ret == NodeVal.Success && n35c < 39) {
                            node = ++n35c;
                        } else {
                            n35c = 37;
                            node = 77;
                            ret = n35_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(23, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 36:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(16, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n36c = 40;
                        node = 40;
                        n36_1r = NodeVal.Success;
                        break;
                    case 81:

                        n36_1r = (NodeVal)System.Math.Max((int)n36_1r, (int)ret);
                        if (ret == NodeVal.Success && n36c < 44) {
                            node = ++n36c;
                        } else {
                            n36c = 40;
                            node = 77;
                            ret = n36_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(16, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 37:

                        ret = (!this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(24, _liveHandle, ret, false, false);
                        #endif
                        node = 80;
                        break;
                    case 38:

                        ret = (this.foundPlayer)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(22, _liveHandle, ret, false, false);
                        #endif
                        node = 80;
                        break;
                    case 39:


                        do
                        {
                            ret = (this.FightPlayer());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(14, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 80;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(14, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 40:

                        ret = (!this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(15, _liveHandle, ret, false, false);
                        #endif
                        node = 81;
                        break;
                    case 41:

                        ret = (!this.foundPlayer)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(21, _liveHandle, ret, false, false);
                        #endif
                        node = 81;
                        break;
                    case 42:


                        do
                        {
                            ret = (this.Infleunce());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(20, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 81;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(20, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 43:

                        ret = (this.targetIsWilling)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(19, _liveHandle, ret, false, false);
                        #endif
                        node = 81;
                        break;
                    case 44:


                        do
                        {
                            ret = (this.AddToGang());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(18, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 81;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(18, _liveHandle, ret, false, false);
                        #endif

                        break;
                }

            } while (node >= 0);

            yield return null;
        }

        public void ResetTree()
        {
            if (_jmp != 0)
            {
                _jmp = 0;
            }
        }

#if UNITY_EDITOR
        public bool SetLive(LiveUpdate live, string treeKey, string codeKey, int liveHandle, out bool codeMatch) {
            if (treeKey == "uwiErlMF00601FVXlizvHw") {
                _live = live;
                codeMatch = (codeKey == "6RElrnj8VkWhTGgEn/tpVA");
                if (codeMatch) {
                    _liveHandle = liveHandle;
                }
                return true;
            }
            codeMatch = false;
            return false;
        }
#endif

        
    }

}
