#ifndef __S2_BSS_SOUNDWEB_LONDON_MATRIX_ROUTER_H__
#define __S2_BSS_SOUNDWEB_LONDON_MATRIX_ROUTER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Matrix_Router_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Matrix_Router_UNSUBSCRIBE$_DIG_INPUT 1

#define __S2_BSS_Soundweb_London_Matrix_Router_OUTPUT_MUTE$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Matrix_Router_OUTPUT_MUTE$_ARRAY_LENGTH 48

/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Matrix_Router_INPUT$_ANALOG_INPUT 0


#define __S2_BSS_Soundweb_London_Matrix_Router_RX$_BUFFER_INPUT 1
#define __S2_BSS_Soundweb_London_Matrix_Router_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Router, __RX$, __S2_BSS_Soundweb_London_Matrix_Router_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Matrix_Router_OUTPUT_MUTE_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Matrix_Router_OUTPUT_MUTE_FB$_ARRAY_LENGTH 48

/*
* ANALOG_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Matrix_Router_TX$_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Matrix_Router_IMAXOUTPUT_INTEGER_PARAMETER 11
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
#define __S2_BSS_Soundweb_London_Matrix_Router_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Matrix_Router_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Router, __OBJECTID$, __S2_BSS_Soundweb_London_Matrix_Router_OBJECTID$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Matrix_Router_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Router, __TEMPSTRING, __S2_BSS_Soundweb_London_Matrix_Router_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Matrix_Router )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __OUTPUT_MUTE$ );
   DECLARE_IO_ARRAY( __OUTPUT_MUTE_FB$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Router, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Router, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Matrix_Router )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Matrix_Router, __TEMPSTRING );
   unsigned short __I;
   unsigned short __SUBSCRIBE;
   unsigned short __INPUT;
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __STATEVARONOFF;
   unsigned short __STATEVARSUB;
   unsigned short __STATEVARRECEIVE;
   unsigned short __X;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Matrix_Router, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_MATRIX_ROUTER_H__

