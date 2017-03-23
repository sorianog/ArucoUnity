using ArucoUnity.Plugin.Utility;
using System.Runtime.InteropServices;

namespace ArucoUnity
{
  /// \addtogroup aruco_unity_package
  /// \{

  namespace Plugin
  {
    namespace Std
    {
      public class VectorVectorPoint3f : HandleCppPtr
      {
        // Constructor & Destructor
        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_std_vectorVectorPoint3f_new();

        [DllImport("ArucoUnity")]
        static extern void au_std_vectorVectorPoint3f_delete(System.IntPtr vector);

        // Functions
        [DllImport("ArucoUnity")]
        static extern System.IntPtr au_std_vectorVectorPoint3f_at(System.IntPtr vector, uint pos, System.IntPtr exception);

        [DllImport("ArucoUnity")]
        static extern unsafe System.IntPtr* au_std_vectorVectorPoint3f_data(System.IntPtr vector);

        [DllImport("ArucoUnity")]
        static extern void au_std_vectorVectorPoint3f_push_back(System.IntPtr vector, System.IntPtr value);

        [DllImport("ArucoUnity")]
        static extern uint au_std_vectorVectorPoint3f_size(System.IntPtr vector);

        public VectorVectorPoint3f() : base(au_std_vectorVectorPoint3f_new())
        {
        }

        public VectorVectorPoint3f(System.IntPtr vectorVectorPoint3fPtr, DeleteResponsibility deleteResponsibility = DeleteResponsibility.True)
          : base(vectorVectorPoint3fPtr, deleteResponsibility)
        {
        }

        protected override void DeleteCvPtr()
        {
          au_std_vectorVectorPoint3f_delete(cppPtr);
        }

        public VectorPoint3f At(uint pos)
        {
          Cv.Exception exception = new Cv.Exception();
          VectorPoint3f element = new VectorPoint3f(au_std_vectorVectorPoint3f_at(cppPtr, pos, exception.cppPtr), DeleteResponsibility.False);
          exception.Check();
          return element;
        }

        public unsafe VectorPoint3f[] Data()
        {
          System.IntPtr* dataPtr = au_std_vectorVectorPoint3f_data(cppPtr);
          uint size = Size();

          VectorPoint3f[] data = new VectorPoint3f[size];
          for (int i = 0; i < size; i++)
          {
            data[i] = new VectorPoint3f(dataPtr[i], DeleteResponsibility.False);
          }

          return data;
        }

        public void PushBack(VectorPoint3f value)
        {
          au_std_vectorVectorPoint3f_push_back(cppPtr, value.cppPtr);
        }

        public uint Size()
        {
          return au_std_vectorVectorPoint3f_size(cppPtr);
        }
      }
    }
  }

  /// \} aruco_unity_package
}