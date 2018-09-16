﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeleeLib.DAT;

namespace Smash_Forge
{
    public class MeleeNode : TreeNode
    {
        public MeleeDataNode GetDatFile()
        {
            TreeNode P = Parent;
            while (P != null)
            {
                if (P is MeleeDataNode)
                    return (MeleeDataNode)P;
                P = P.Parent;
            }
            return null;
        }

        public MeleeRootNode GetRoot()
        {
            TreeNode P = Parent;
            while (P != null)
            {
                if (P is MeleeRootNode)
                    return (MeleeRootNode)P;
                P = P.Parent;
            }
            return null;
        }
    }
}