﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// Type-specific abstract matrix 
    /// </summary>
    /// <typeparam name="TElem">Element Type</typeparam>
    /// <typeparam name="TInherit">For return value type of re-defined Mat methods</typeparam>
    public abstract class Mat<TElem, TInherit> : Mat, IEnumerable<TElem> 
        where TElem : struct
        where TInherit : Mat, new()
    {
        #region Init

#if LANG_JP
        /// <summary>
        /// Creates empty Mat
        /// </summary>
#else
        /// <summary>
        /// Creates empty Mat
        /// </summary>
#endif
        protected Mat()
            : base()
        {
        }

#if LANG_JP
        /// <summary>
        /// OpenCVネイティブの cv::Mat* ポインタから初期化
        /// </summary>
        /// <param name="ptr"></param>
#else
        /// <summary>
        /// Creates from native cv::Mat* pointer
        /// </summary>
        /// <param name="ptr"></param>
#endif
        protected Mat(IntPtr ptr)
            : base(ptr)
        {
        }

#if LANG_JP
        /// <summary>
        /// Matオブジェクトから初期化 
        /// </summary>
        /// <param name="mat">Matオブジェクト</param>
#else
        /// <summary>
        /// Initializes by Mat object
        /// </summary>
        /// <param name="mat">Managed Mat object</param>
#endif
        protected Mat(Mat mat)
            : base(mat.CvPtr)
        {
        }

#if LANG_JP
        /// <summary>
        /// 指定したサイズ・型の2次元の行列として初期化
        /// </summary>
        /// <param name="rows">2次元配列における行数．</param>
        /// <param name="cols">2次元配列における列数．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
#else
        /// <summary>
        /// constructs 2D matrix of the specified size and type
        /// </summary>
        /// <param name="rows">Number of rows in a 2D array.</param>
        /// <param name="cols">Number of columns in a 2D array.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
#endif
        protected Mat(int rows, int cols, MatType type)
            : base(rows, cols, type)
        {
        }

#if LANG_JP
        /// <summary>
        /// 指定したサイズ・型の2次元の行列として初期化
        /// </summary>
        /// <param name="size">2次元配列のサイズ： Size(cols, rows) ． Size コンストラクタでは，行数と列数が逆順になっていることに注意してください．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
#else
        /// <summary>
        /// constructs 2D matrix of the specified size and type
        /// </summary>
        /// <param name="size">2D array size: Size(cols, rows) . In the Size() constructor, 
        /// the number of rows and the number of columns go in the reverse order.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType.CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
#endif
        protected Mat(Size size, MatType type)
            : base(size, type)
        {
        }

#if LANG_JP
        /// <summary>
        /// 指定したサイズ・型の2次元の行列で、要素をスカラー値で埋めて初期化
        /// </summary>
        /// <param name="rows">2次元配列における行数．</param>
        /// <param name="cols">2次元配列における列数．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="s">各行列要素を初期化するオプション値．初期化の後ですべての行列要素を特定の値にセットするには，
        /// コンストラクタの後で，SetTo(Scalar value) メソッドを利用してください．</param>
#else
        /// <summary>
        /// constucts 2D matrix and fills it with the specified Scalar value.
        /// </summary>
        /// <param name="rows">Number of rows in a 2D array.</param>
        /// <param name="cols">Number of columns in a 2D array.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
        /// <param name="s">An optional value to initialize each matrix element with. 
        /// To set all the matrix elements to the particular value after the construction, use SetTo(Scalar s) method .</param>
#endif
        protected Mat(int rows, int cols, MatType type, Scalar s)
            : base(rows, cols, type, s)
        {
        }

#if LANG_JP
        /// <summary>
        /// 指定したサイズ・型の2次元の行列で、要素をスカラー値で埋めて初期化
        /// </summary>
        /// <param name="size"> 2 次元配列のサイズ： Size(cols, rows) ． Size() コンストラクタでは，行数と列数が逆順になっていることに注意してください．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="s">各行列要素を初期化するオプション値．初期化の後ですべての行列要素を特定の値にセットするには，
        /// コンストラクタの後で，SetTo(Scalar value) メソッドを利用してください．</param>
#else
        /// <summary>
        /// constucts 2D matrix and fills it with the specified Scalar value.
        /// </summary>
        /// <param name="size">2D array size: Size(cols, rows) . In the Size() constructor, 
        /// the number of rows and the number of columns go in the reverse order.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or CV_8UC(n), ..., CV_64FC(n) to create multi-channel (up to CV_CN_MAX channels) matrices.</param>
        /// <param name="s">An optional value to initialize each matrix element with. 
        /// To set all the matrix elements to the particular value after the construction, use SetTo(Scalar s) method .</param>
#endif
        protected Mat(Size size, MatType type, Scalar s)
            : base(size, type, s)
        {
        }


#if LANG_JP
        /// <summary>
        /// 他の行列の部分行列として初期化
        /// </summary>
        /// <param name="m">作成された行列に（全体的，部分的に）割り当てられる配列．
        /// これらのコンストラクタによってデータがコピーされる事はありません．
        /// 代わりに，データ m ，またはその部分配列を指し示すヘッダが作成され，
        /// 関連した参照カウンタがあれば，それがインクリメントされます．
        /// つまり，新しく作成された配列の内容を変更することで， m の対応する要素も
        /// 変更することになります．もし部分配列の独立したコピーが必要ならば，
        /// Mat.Clone() を利用してください．</param>
        /// <param name="rowRange">扱われる 行列の行の範囲．すべての行を扱う場合は，Range.All を利用してください．</param>
        /// <param name="colRange">扱われる 行列の列の範囲．すべての列を扱う場合は，Range.All を利用してください．</param>
#else
        /// <summary>
        /// creates a matrix header for a part of the bigger matrix
        /// </summary>
        /// <param name="m">Array that (as a whole or partly) is assigned to the constructed matrix. 
        /// No data is copied by these constructors. Instead, the header pointing to m data or its sub-array 
        /// is constructed and associated with it. The reference counter, if any, is incremented. 
        /// So, when you modify the matrix formed using such a constructor, you also modify the corresponding elements of m . 
        /// If you want to have an independent copy of the sub-array, use Mat::clone() .</param>
        /// <param name="rowRange">Range of the m rows to take. As usual, the range start is inclusive and the range end is exclusive. 
        /// Use Range.All to take all the rows.</param>
        /// <param name="colRange">Range of the m columns to take. Use Range.All to take all the columns.</param>
#endif
        protected Mat(Mat<TElem, TInherit> m, Range rowRange, Range? colRange = null)
            : base(m, rowRange, colRange)
        {
        }

#if LANG_JP
        /// <summary>
        /// 他の行列の部分行列として初期化
        /// </summary>
        /// <param name="m">作成された行列に（全体的，部分的に）割り当てられる配列．
        /// これらのコンストラクタによってデータがコピーされる事はありません．
        /// 代わりに，データ m ，またはその部分配列を指し示すヘッダが作成され，
        /// 関連した参照カウンタがあれば，それがインクリメントされます．
        /// つまり，新しく作成された配列の内容を変更することで， m の対応する要素も
        /// 変更することになります．もし部分配列の独立したコピーが必要ならば，
        /// Mat.Clone() を利用してください．</param>
        /// <param name="ranges">多次元行列の各次元毎の選択範囲を表す配列．</param>
#else
        /// <summary>
        /// creates a matrix header for a part of the bigger matrix
        /// </summary>
        /// <param name="m">Array that (as a whole or partly) is assigned to the constructed matrix. 
        /// No data is copied by these constructors. Instead, the header pointing to m data or its sub-array 
        /// is constructed and associated with it. The reference counter, if any, is incremented. 
        /// So, when you modify the matrix formed using such a constructor, you also modify the corresponding elements of m . 
        /// If you want to have an independent copy of the sub-array, use Mat.Clone() .</param>
        /// <param name="ranges">Array of selected ranges of m along each dimensionality.</param>
#endif
        protected Mat(Mat<TElem, TInherit> m, params Range[] ranges)
            : base(m, ranges)
        {
        }

#if LANG_JP
        /// <summary>
        /// 他の行列の部分行列として初期化
        /// </summary>
        /// <param name="m">作成された行列に（全体的，部分的に）割り当てられる配列．
        /// これらのコンストラクタによってデータがコピーされる事はありません．
        /// 代わりに，データ m ，またはその部分配列を指し示すヘッダが作成され，
        /// 関連した参照カウンタがあれば，それがインクリメントされます．
        /// つまり，新しく作成された配列の内容を変更することで， m の対応する要素も
        /// 変更することになります．もし部分配列の独立したコピーが必要ならば，
        /// Mat.Clone() を利用してください．</param>
        /// <param name="roi">元の行列からくりぬかれる範囲. ROI[Region of interest].</param>
#else
        /// <summary>
        /// creates a matrix header for a part of the bigger matrix
        /// </summary>
        /// <param name="m">Array that (as a whole or partly) is assigned to the constructed matrix. 
        /// No data is copied by these constructors. Instead, the header pointing to m data or its sub-array 
        /// is constructed and associated with it. The reference counter, if any, is incremented. 
        /// So, when you modify the matrix formed using such a constructor, you also modify the corresponding elements of m . 
        /// If you want to have an independent copy of the sub-array, use Mat.Clone() .</param>
        /// <param name="roi">Region of interest.</param>
#endif
        protected Mat(Mat<TElem, TInherit> m, Rect roi)
            : base(m, roi)
        {
        }

#if LANG_JP
        /// <summary>
        /// 利用者が別に確保したデータで初期化
        /// </summary>
        /// <param name="rows">2次元配列における行数．</param>
        /// <param name="cols">2次元配列における列数．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="data">ユーザデータへのポインタ． data と step パラメータを引数にとる
        /// 行列コンストラクタは，行列データ領域を確保しません．代わりに，指定のデータを指し示す
        /// 行列ヘッダを初期化します．つまり，データのコピーは行われません．
        /// この処理は，非常に効率的で，OpenCV の関数を利用して外部データを処理することができます．
        /// 外部データが自動的に解放されることはありませんので，ユーザが解放する必要があります．</param>
        /// <param name="step">行列の各行が占めるバイト数を指定できます．
        /// この値は，各行の終端にパディングバイトが存在すれば，それも含みます．
        /// このパラメータが指定されない場合，パディングは存在しないとみなされ，
        /// 実際の step は cols*elemSize() として計算されます．</param>
#else
        /// <summary>
        /// constructor for matrix headers pointing to user-allocated data
        /// </summary>
        /// <param name="rows">Number of rows in a 2D array.</param>
        /// <param name="cols">Number of columns in a 2D array.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
        /// <param name="data">Pointer to the user data. Matrix constructors that take data and step parameters do not allocate matrix data. 
        /// Instead, they just initialize the matrix header that points to the specified data, which means that no data is copied. 
        /// This operation is very efficient and can be used to process external data using OpenCV functions. 
        /// The external data is not automatically deallocated, so you should take care of it.</param>
        /// <param name="step">Number of bytes each matrix row occupies. The value should include the padding bytes at the end of each row, if any.
        /// If the parameter is missing (set to AUTO_STEP ), no padding is assumed and the actual step is calculated as cols*elemSize() .</param>
#endif
        protected Mat(int rows, int cols, MatType type, IntPtr data, long step = 0)
            : base(rows, cols, type, data, step)
        {
        }

#if LANG_JP
        /// <summary>
        /// 利用者が別に確保したデータで初期化
        /// </summary>
        /// <param name="rows">2次元配列における行数．</param>
        /// <param name="cols">2次元配列における列数．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="data">ユーザデータへのポインタ． data と step パラメータを引数にとる
        /// 行列コンストラクタは，行列データ領域を確保しません．代わりに，指定のデータを指し示す
        /// 行列ヘッダを初期化します．つまり，データのコピーは行われません．
        /// この処理は，非常に効率的で，OpenCV の関数を利用して外部データを処理することができます．
        /// 外部データが自動的に解放されることはありませんので，ユーザが解放する必要があります．</param>
        /// <param name="step">行列の各行が占めるバイト数を指定できます．
        /// この値は，各行の終端にパディングバイトが存在すれば，それも含みます．
        /// このパラメータが指定されない場合，パディングは存在しないとみなされ，
        /// 実際の step は cols*elemSize() として計算されます．</param>
#else
        /// <summary>
        /// constructor for matrix headers pointing to user-allocated data
        /// </summary>
        /// <param name="rows">Number of rows in a 2D array.</param>
        /// <param name="cols">Number of columns in a 2D array.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
        /// <param name="data">Pointer to the user data. Matrix constructors that take data and step parameters do not allocate matrix data. 
        /// Instead, they just initialize the matrix header that points to the specified data, which means that no data is copied. 
        /// This operation is very efficient and can be used to process external data using OpenCV functions. 
        /// The external data is not automatically deallocated, so you should take care of it.</param>
        /// <param name="step">Number of bytes each matrix row occupies. The value should include the padding bytes at the end of each row, if any.
        /// If the parameter is missing (set to AUTO_STEP ), no padding is assumed and the actual step is calculated as cols*elemSize() .</param>
#endif
        protected Mat(int rows, int cols, MatType type, Array data, long step = 0)
            : base(rows, cols, type, data, step)
        {
        }

#if LANG_JP
        /// <summary>
        /// 利用者が別に確保したデータで初期化
        /// </summary>
        /// <param name="sizes">Array of integers specifying an n-dimensional array shape.</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="data">ユーザデータへのポインタ． data と step パラメータを引数にとる
        /// 行列コンストラクタは，行列データ領域を確保しません．代わりに，指定のデータを指し示す
        /// 行列ヘッダを初期化します．つまり，データのコピーは行われません．
        /// この処理は，非常に効率的で，OpenCV の関数を利用して外部データを処理することができます．
        /// 外部データが自動的に解放されることはありませんので，ユーザが解放する必要があります．</param>
        /// <param name="steps">多次元配列における ndims-1 個のステップを表す配列
        /// （最後のステップは常に要素サイズになります）．これが指定されないと，
        /// 行列は連続したものとみなされます．</param>
#else
        /// <summary>
        /// constructor for matrix headers pointing to user-allocated data
        /// </summary>
        /// <param name="sizes">Array of integers specifying an n-dimensional array shape.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
        /// <param name="data">Pointer to the user data. Matrix constructors that take data and step parameters do not allocate matrix data. 
        /// Instead, they just initialize the matrix header that points to the specified data, which means that no data is copied. 
        /// This operation is very efficient and can be used to process external data using OpenCV functions. 
        /// The external data is not automatically deallocated, so you should take care of it.</param>
        /// <param name="steps">Array of ndims-1 steps in case of a multi-dimensional array (the last step is always set to the element size). 
        /// If not specified, the matrix is assumed to be continuous.</param>
#endif
        protected Mat(IEnumerable<int> sizes, MatType type, IntPtr data, IEnumerable<long> steps = null)
            : base(sizes, type, data, steps)
        {
        }

#if LANG_JP
        /// <summary>
        /// 利用者が別に確保したデータで初期化
        /// </summary>
        /// <param name="sizes">n-次元配列の形状を表す，整数型の配列．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="data">ユーザデータへのポインタ． data と step パラメータを引数にとる
        /// 行列コンストラクタは，行列データ領域を確保しません．代わりに，指定のデータを指し示す
        /// 行列ヘッダを初期化します．つまり，データのコピーは行われません．
        /// この処理は，非常に効率的で，OpenCV の関数を利用して外部データを処理することができます．
        /// 外部データが自動的に解放されることはありませんので，ユーザが解放する必要があります．</param>
        /// <param name="steps">多次元配列における ndims-1 個のステップを表す配列
        /// （最後のステップは常に要素サイズになります）．これが指定されないと，
        /// 行列は連続したものとみなされます．</param>
#else
        /// <summary>
        /// constructor for matrix headers pointing to user-allocated data
        /// </summary>
        /// <param name="sizes">Array of integers specifying an n-dimensional array shape.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
        /// <param name="data">Pointer to the user data. Matrix constructors that take data and step parameters do not allocate matrix data. 
        /// Instead, they just initialize the matrix header that points to the specified data, which means that no data is copied. 
        /// This operation is very efficient and can be used to process external data using OpenCV functions. 
        /// The external data is not automatically deallocated, so you should take care of it.</param>
        /// <param name="steps">Array of ndims-1 steps in case of a multi-dimensional array (the last step is always set to the element size). 
        /// If not specified, the matrix is assumed to be continuous.</param>
#endif
        protected Mat(IEnumerable<int> sizes, MatType type, Array data, IEnumerable<long> steps = null)
            : base(sizes, type, data, steps)
        {
        }

#if LANG_JP
        /// <summary>
        /// N次元行列として初期化
        /// </summary>
        /// <param name="sizes">n-次元配列の形状を表す，整数型の配列．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
#else
        /// <summary>
        /// constructs n-dimensional matrix
        /// </summary>
        /// <param name="sizes">Array of integers specifying an n-dimensional array shape.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
#endif
        protected Mat(IEnumerable<int> sizes, MatType type)
            : base(sizes, type)
        {
        }

#if LANG_JP
        /// <summary>
        /// N次元行列として初期化
        /// </summary>
        /// <param name="sizes">n-次元配列の形状を表す，整数型の配列．</param>
        /// <param name="type">配列の型．1-4 チャンネルの行列を作成するには MatType.CV_8UC1, ..., CV_64FC4 を，
        /// マルチチャンネルの行列を作成するには，MatType.CV_8UC(n), ..., CV_64FC(n) を利用してください．</param>
        /// <param name="s">各行列要素を初期化するオプション値．初期化の後ですべての行列要素を特定の値にセットするには，
        /// コンストラクタの後で，SetTo(Scalar value) メソッドを利用してください．</param>
#else
        /// <summary>
        /// constructs n-dimensional matrix
        /// </summary>
        /// <param name="sizes">Array of integers specifying an n-dimensional array shape.</param>
        /// <param name="type">Array type. Use MatType.CV_8UC1, ..., CV_64FC4 to create 1-4 channel matrices, 
        /// or MatType. CV_8UC(n), ..., CV_64FC(n) to create multi-channel matrices.</param>
        /// <param name="s">An optional value to initialize each matrix element with. 
        /// To set all the matrix elements to the particular value after the construction, use SetTo(Scalar s) method .</param>
#endif
        protected Mat(IEnumerable<int> sizes, MatType type, Scalar s)
            : base(sizes, type, s)
        {
        }

#if LANG_JP
        /// <summary>
        /// CvMatデータから初期化
        /// </summary>
        /// <param name="m">CvMat 行列構造体へのポインタ．
        /// デフォルトでは，元の画像と新しい行列とでデータが共有されますが，
        /// copyData フラグがセットされている場合は，画像データの完全なコピーが作成されます．</param>
        /// <param name="copyData">古い形式の CvMat または IplImage を新しく作成される行列に
        /// コピーする（true）か，共有する（false）かを指定するフラグです．
        /// データがコピーされる場合，確保されたバッファは Mat の参照カウント機構を用いて管理されます．
        /// データが共有される場合，参照カウンタは NULL になり，ユーザは，作成された行列が
        /// デストラクトされない限り，データを解放するべきではありません．</param>
#else
        /// <summary>
        /// converts old-style CvMat to the new matrix; the data is not copied by default
        /// </summary>
        /// <param name="m">Old style CvMat object</param>
        /// <param name="copyData">Flag to specify whether the underlying data of the the old-style CvMat should be 
        /// copied to (true) or shared with (false) the newly constructed matrix. When the data is copied, 
        /// the allocated buffer is managed using Mat reference counting mechanism. While the data is shared, 
        /// the reference counter is NULL, and you should not deallocate the data until the matrix is not destructed.</param>
#endif
        protected Mat(CvMat m, bool copyData = false)
            : base(m, copyData)
        {
        }

#if LANG_JP
        /// <summary>
        /// IplImageデータから初期化
        /// </summary>
        /// <param name="img">IplImage 画像構造体へのポインタ．
        /// デフォルトでは，元の画像と新しい行列とでデータが共有されますが，
        /// copyData フラグがセットされている場合は，画像データの完全なコピーが作成されます．</param>
        /// <param name="copyData">古い形式の CvMat または IplImage を新しく作成される行列に
        /// コピーする（true）か，共有する（false）かを指定するフラグです．
        /// データがコピーされる場合，確保されたバッファは Mat の参照カウント機構を用いて管理されます．
        /// データが共有される場合，参照カウンタは NULL になり，ユーザは，作成された行列が
        /// デストラクトされない限り，データを解放するべきではありません．</param>
#else
        /// <summary>
        /// converts old-style IplImage to the new matrix; the data is not copied by default
        /// </summary>
        /// <param name="img">Old style IplImage object</param>
        /// <param name="copyData">Flag to specify whether the underlying data of the the old-style IplImage should be 
        /// copied to (true) or shared with (false) the newly constructed matrix. When the data is copied, 
        /// the allocated buffer is managed using Mat reference counting mechanism. While the data is shared, 
        /// the reference counter is NULL, and you should not deallocate the data until the matrix is not destructed.</param>
#endif
        protected Mat(IplImage img, bool copyData = false)
            : base(img, copyData)
        {
        }  

        #endregion

        #region Abstract Methods
        /// <summary>
        /// Gets type-specific indexer for accessing each element
        /// </summary>
        /// <returns></returns>
        public abstract MatIndexer<TElem> GetIndexer();

        /// <summary>
        /// Gets read-only enumerator
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerator<TElem> GetEnumerator();
        /// <summary>
        /// For non-generic IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Convert this mat to managed array
        /// </summary>
        /// <returns></returns>
        public abstract TElem[] ToArray();

        /// <summary>
        /// Convert this mat to managed rectangular array
        /// </summary>
        /// <returns></returns>
        public abstract TElem[,] ToRectangularArray();

        /// <summary>
        /// Adds elements to the bottom of the matrix. (Mat::push_back)
        /// </summary>
        /// <param name="value">Added element(s)</param>
        public abstract void Add(TElem value);
        #endregion

        #region Mat Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        protected TInherit Wrap(Mat mat)
        {
            TInherit ret = new TInherit();
            mat.AssignTo(ret);
            return ret;
        }

        #region Reshape

        /// <summary>
        /// Changes the shape and/or the number of channels of a 2D matrix without copying the data.
        /// </summary>
        /// <param name="cn">New number of channels. If the parameter is 0, the number of channels remains the same.</param>
        /// <param name="rows">New number of rows. If the parameter is 0, the number of rows remains the same.</param>
        /// <returns></returns>
        public new TInherit Reshape(int cn, int rows = 0)
        {
            Mat result = base.Reshape(cn, rows);
            return Wrap(result);
        }

        /// <summary>
        /// Changes the shape and/or the number of channels of a 2D matrix without copying the data.
        /// </summary>
        /// <param name="cn">New number of channels. If the parameter is 0, the number of channels remains the same.</param>
        /// <param name="newDims">New number of rows. If the parameter is 0, the number of rows remains the same.</param>
        /// <returns></returns>
        public new TInherit Reshape(int cn, params int[] newDims)
        {
            Mat result = base.Reshape(cn, newDims);
            return Wrap(result);
        }

        #endregion
        #endregion
    }
}
