//%GenSrc:1:uwiErlMF00601FVXlizvHw
//%CodeKey:vUH4Qa/ATUKWR07IUcAT2w
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
            int n1c = -1;
            int n23c = -1;
            int n24c = -1;
            int n27c = -1;
            int n28c = -1;
            int n2c = -1;
            int n4c = -1;
            int n5c = -1;
            int n6c = -1;
            int n8c = -1;
            NodeVal n1_1r = NodeVal.Invalid;
            NodeVal n2_1r = NodeVal.Invalid;
            NodeVal n27_1r = NodeVal.Invalid;
            NodeVal n28_1r = NodeVal.Invalid;
            NodeVal n5_1r = NodeVal.Invalid;
            NodeVal n6_1r = NodeVal.Invalid;
            NodeVal n8_1r = NodeVal.Invalid;
            Vector3 v1 = Vector3.zero;

            if (!valid) {
                throw new BehaviourTreeException("Behaviour tree will not run. The GameObject has missing required components.");
            }
            do {
                switch (node) {
                    case 0:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(0, _liveHandle, NodeVal.Running, false, true);
                        #endif
                        n0c = 1;
                        node = 1;
                        break;
                    case 35:

                        if (_jmp >= 0) {
                            node = _jmp;
                            _jmp = -1;
                            continue;
                        }
                        if(ret != NodeVal.Success) {
                            if (++n0c > 2) {
                                n0c = 1;
                                node = 0;
                                yield return null;
                            } else {
                                node = n0c;
                            }
                        } else {
                            n0c = 1;
                            node = 0;
                            yield return null;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(0, _liveHandle, ret, true, false);
                        #endif
                        break;
                    case 1:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(3, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n1c = 3;
                        node = 3;
                        n1_1r = NodeVal.Success;
                        break;
                    case 36:

                        n1_1r = (NodeVal)System.Math.Max((int)n1_1r, (int)ret);
                        if (ret == NodeVal.Success && n1c < 4) {
                            node = ++n1c;
                        } else {
                            n1c = 3;
                            node = 35;
                            ret = n1_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(3, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 2:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(2, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n2c = 21;
                        node = 21;
                        n2_1r = NodeVal.Success;
                        break;
                    case 37:

                        n2_1r = (NodeVal)System.Math.Max((int)n2_1r, (int)ret);
                        if (ret == NodeVal.Success && n2c < 24) {
                            node = ++n2c;
                        } else {
                            n2c = 21;
                            node = 35;
                            ret = n2_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(2, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 3:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(4, _liveHandle, ret, false, false);
                        #endif
                        node = 36;
                        break;
                    case 4:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(32, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n4c = 5;
                        node = 5;
                        break;
                    case 39:

                        if(ret != NodeVal.Success) {
                            if (++n4c > 6) {
                                n4c = 5;
                                node = 36;
                            } else {
                                node = n4c;
                            }
                        } else {
                            n4c = 5;
                            node = 36;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(32, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 5:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(33, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n5c = 7;
                        node = 7;
                        n5_1r = NodeVal.Success;
                        break;
                    case 40:

                        n5_1r = (NodeVal)System.Math.Max((int)n5_1r, (int)ret);
                        if (ret == NodeVal.Success && n5c < 8) {
                            node = ++n5c;
                        } else {
                            n5c = 7;
                            node = 39;
                            ret = n5_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(33, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 6:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(19, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n6c = 15;
                        node = 15;
                        n6_1r = NodeVal.Success;
                        break;
                    case 41:

                        n6_1r = (NodeVal)System.Math.Max((int)n6_1r, (int)ret);
                        if (ret == NodeVal.Success && n6c < 20) {
                            node = ++n6c;
                        } else {
                            n6c = 15;
                            node = 39;
                            ret = n6_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(19, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 7:

                        ret = (this.hasMin)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(6, _liveHandle, ret, false, false);
                        #endif
                        node = 40;
                        break;
                    case 8:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(5, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n8c = 9;
                        node = 9;
                        n8_1r = NodeVal.Success;
                        break;
                    case 43:

                        n8_1r = (NodeVal)System.Math.Max((int)n8_1r, (int)ret);
                        if (ret == NodeVal.Success && n8c < 14) {
                            node = ++n8c;
                        } else {
                            n8c = 9;
                            node = 40;
                            ret = n8_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(5, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 9:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(36, _liveHandle, ret, false, false);
                        #endif
                        node = 43;
                        break;
                    case 10:


                        do
                        {
                            ret = (this.FindPlayer());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(35, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 43;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(35, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 11:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(34, _liveHandle, ret, false, false);
                        #endif
                        node = 43;
                        break;
                    case 12:


                        do
                        {
                            ret = (this.Wander());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(37, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 43;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(37, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 13:


                        do
                        {
                                v1 = (this.targetLocation).position;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 1f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(7, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 43;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(7, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 14:


                        do
                        {
                            ret = (this.FindPlayer());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(38, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 43;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(38, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 15:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(14, _liveHandle, ret, false, false);
                        #endif
                        node = 41;
                        break;
                    case 16:


                        do
                        {
                            ret = (this.FindMember());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(15, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 41;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(15, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 17:

                        ret = (this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(13, _liveHandle, ret, false, false);
                        #endif
                        node = 41;
                        break;
                    case 18:


                        do
                        {
                            ret = (this.Wander());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(16, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 41;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(16, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 19:


                        do
                        {
                                v1 = (this.targetLocation).position;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 5f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(17, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 41;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(17, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 20:


                        do
                        {
                            ret = (this.FindMember());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(18, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 41;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(18, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 21:

                        ret = (!this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(8, _liveHandle, ret, false, false);
                        #endif
                        node = 37;
                        break;
                    case 22:

                        ret = (!this.hasMin)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(9, _liveHandle, ret, false, false);
                        #endif
                        node = 37;
                        break;
                    case 23:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(10, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n23c = 25;
                        node = 25;
                        break;
                    case 58:

                        if(ret != NodeVal.Success) {
                            if (++n23c > 26) {
                                n23c = 25;
                                node = 37;
                            } else {
                                node = n23c;
                            }
                        } else {
                            n23c = 25;
                            node = 37;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(10, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 24:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(28, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n24c = 27;
                        node = 27;
                        break;
                    case 59:

                        if(ret != NodeVal.Success) {
                            if (++n24c > 28) {
                                n24c = 27;
                                node = 37;
                            } else {
                                node = n24c;
                            }
                        } else {
                            n24c = 27;
                            node = 37;
                        }

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(28, _liveHandle, ret, false, false);
                        #endif
                        break;
                    case 25:

                        ret = ((transform.position - (this.targetLocation).position).sqrMagnitude < (0.25f))? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(11, _liveHandle, ret, false, false);
                        #endif
                        node = 58;
                        break;
                    case 26:


                        do
                        {
                                v1 = (this.targetLocation).position;
                            transform.position = Vector3.MoveTowards(transform.position, v1, 5f * Time.deltaTime);
                            ret = (transform.position == v1)? NodeVal.Success : NodeVal.Running;
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(12, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 58;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(12, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 27:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(20, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n27c = 29;
                        node = 29;
                        n27_1r = NodeVal.Success;
                        break;
                    case 62:

                        n27_1r = (NodeVal)System.Math.Max((int)n27_1r, (int)ret);
                        if (ret == NodeVal.Success && n27c < 30) {
                            node = ++n27c;
                        } else {
                            n27c = 29;
                            node = 59;
                            ret = n27_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(20, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 28:

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(27, _liveHandle, NodeVal.Running, false, false);
                        #endif
                        n28c = 31;
                        node = 31;
                        n28_1r = NodeVal.Success;
                        break;
                    case 63:

                        n28_1r = (NodeVal)System.Math.Max((int)n28_1r, (int)ret);
                        if (ret == NodeVal.Success && n28c < 34) {
                            node = ++n28c;
                        } else {
                            n28c = 31;
                            node = 59;
                            ret = n28_1r;

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(27, _liveHandle, ret, false, false);
                        #endif

                        }
                        break;
                    case 29:

                        ret = (this.foundPlayer)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(21, _liveHandle, ret, false, false);
                        #endif
                        node = 62;
                        break;
                    case 30:


                        do
                        {
                            ret = (this.FightPlayer());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(22, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 62;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(22, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 31:

                        ret = (!this.memberHunting)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(23, _liveHandle, ret, false, false);
                        #endif
                        node = 63;
                        break;
                    case 32:


                        do
                        {
                            ret = (this.Infleunce());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(24, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 63;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(24, _liveHandle, ret, false, false);
                        #endif

                        break;
                    case 33:

                        ret = (this.targetIsWilling)? NodeVal.Success : NodeVal.Fail;
                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(25, _liveHandle, ret, false, false);
                        #endif
                        node = 63;
                        break;
                    case 34:


                        do
                        {
                            ret = (this.AddToGang());
                            if (ret == NodeVal.Running) {

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(26, _liveHandle, NodeVal.Running, true, false);
                        #endif
                                yield return null;
                            } else {
                                node = 63;
                                break;
                            }
                        } while (true);

                        #if UNITY_EDITOR
                            if (_live != null) _live = _live.SetLiveValue(26, _liveHandle, ret, false, false);
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
                codeMatch = (codeKey == "vUH4Qa/ATUKWR07IUcAT2w");
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
