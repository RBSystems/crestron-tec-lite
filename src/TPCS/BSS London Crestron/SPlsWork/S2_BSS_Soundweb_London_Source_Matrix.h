#ifndef __S2_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_H__
#define __S2_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Source_Matrix_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Source_Matrix_UNSUBSCRIBE$_DIG_INPUT 1


/*
* ANALOG_INPUT
*/


#define __S2_BSS_Soundweb_London_Source_Matrix_RX$_BUFFER_INPUT 0
#define __S2_BSS_Soundweb_London_Source_Matrix_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Matrix, __RX$, __S2_BSS_Soundweb_London_Source_Matrix_RX$_BUFFER_MAX_LEN );

#define __S2_BSS_Soundweb_London_Source_Matrix_INPUTFOROUTPUT$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_Source_Matrix_INPUTFOROUTPUT$_ARRAY_LENGTH 96

/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Source_Matrix_TX$_STRING_OUTPUT 0

#define __S2_BSS_Soundweb_London_Source_Matrix_INPUTFOROUTPUT_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Source_Matrix_INPUTFOROUTPUT_FB$_ARRAY_LENGTH 96

/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Source_Matrix_IMAXOUTPUT_INTEGER_PARAMETER 10
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Source_Matrix_OBJECTID$_STRING_PARAMETER 11
#define __S2_BSS_Soundweb_London_Source_Matrix_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Matrix, __OBJECTID$, __S2_BSS_Soundweb_London_Source_Matrix_OBJECTID$_PARAM_MAX_LEN );


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_BSS_Soundweb_London_Source_Matrix_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Matrix, __TEMPSTRING, __S2_BSS_Soundweb_London_Source_Matrix_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Source_Matrix )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __INPUTFOROUTPUT$ );
   DECLARE_IO_ARRAY( __INPUTFOROUTPUT_FB$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Matrix, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Matrix, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Source_Matrix )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Matrix, __TEMPSTRING );
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __I;
   unsigned short __X;
   unsigned short __XINDEX;
   unsigned short __STATEVAR;
   unsigned short __SUBSCRIBE;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Source_Matrix, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_SOURCE_MATRIX_H__

