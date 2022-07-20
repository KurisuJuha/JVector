using System;
using UnityEngine;

namespace JuhaKurisu.JVector
{
    public struct JVector3
    {
        #region �����o�[
        
        public double x;
        public double y;
        public double z;

        #endregion

        #region �R���X�g���N�^�[

        public JVector3(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.z = 0;
        }

        public JVector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion

        #region �v���p�e�B

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;  
                    case 2: return z;
                    default:
                        throw new IndexOutOfRangeException("Invalid JVector3 index");

                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        x = value;
                        break;
                    case 1: 
                        y = value;
                        break;
                    case 2: 
                        z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid JVector3 index");
                }
            }
        }

        public static JVector3 back
        {
            get
            {
                return new JVector3(0, 0, -1);
            }
        }

        public static JVector3 down
        {
            get
            {
                return new JVector3(0, -1, 0);
            }
        }

        public static JVector3 forward
        {
            get
            {
                return new JVector3(0, 0, 1);
            }
        }

        public static JVector3 left
        {
            get
            {
                return new JVector3(-1, 0, 0);
            }
        }

        public static JVector3 one
        {
            get
            {
                return new JVector3(1, 1, 1);
            }
        }

        public static JVector3 right
        {
            get
            {
                return new JVector3(1, 0, 0);
            }
        }

        public static JVector3 up
        {
            get
            {
                return new JVector3(0, 1, 0);
            }
        }

        public static JVector3 zero
        {
            get
            {
                return new JVector3(0, 0, 0);
            }
        }

        public double sqrMagnitude
        {
            get
            {
                return x * x + y * y + z * z;
            }
        }

        public double magnitude
        {
            get
            {
                return Math.Sqrt(sqrMagnitude);
            }
        }

        public JVector3 normalized
        {
            get
            {

            }
        }

        #endregion

        #region ���\�b�h

        public static float Angle(JVector3 from, JVector3 to)
        {
            double cos = Dot(from.normalized, to.normalized);
            if (cos < -1) cos = -1;
            if (cos > 1) cos = 1;

            return (float)(Math.Acos(cos) * (180 / Math.PI));
        }

        public static double Dot(JVector3 lhs, JVector3 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }

        public static float AngleBetween(JVector3 from, JVector3 to)
        {
            double cos = Dot(from.normalized, to.normalized);
            if (cos < -1) cos = -1;
            if (cos > 1) cos = 1;
            return (float)Math.Acos(cos);

        }

        #endregion
    }
}