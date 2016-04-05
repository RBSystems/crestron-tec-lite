#ifndef __S2_BSS_AUDIO_SOUNDWEB_LONDON_NODE_H__
#define __S2_BSS_AUDIO_SOUNDWEB_LONDON_NODE_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/


/*
* ANALOG_INPUT
*/


#define __S2_BSS_Audio_Soundweb_London_Node_COMRX$_BUFFER_INPUT 0
#define __S2_BSS_Audio_Soundweb_London_Node_COMRX$_BUFFER_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __COMRX$, __S2_BSS_Audio_Soundweb_London_Node_COMRX$_BUFFER_MAX_LEN );
#define __S2_BSS_Audio_Soundweb_London_Node_MODULESTX$_BUFFER_INPUT 1
#define __S2_BSS_Audio_Soundweb_London_Node_MODULESTX$_BUFFER_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __MODULESTX$, __S2_BSS_Audio_Soundweb_London_Node_MODULESTX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_BSS_Audio_Soundweb_London_Node_COMTX$_STRING_OUTPUT 0
#define __S2_BSS_Audio_Soundweb_London_Node_MODULESRX$_STRING_OUTPUT 1


/*
* Direct Socket Variables
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
#define __S2_BSS_Audio_Soundweb_London_Node_NODE$_STRING_PARAMETER 10
#define __S2_BSS_Audio_Soundweb_London_Node_NODE$_PARAM_MAX_LEN 2
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __NODE$, __S2_BSS_Audio_Soundweb_London_Node_NODE$_PARAM_MAX_LEN );


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
#define __S2_BSS_Audio_Soundweb_London_Node_TEMPSTRING1_STRING_MAX_LEN 80
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __TEMPSTRING1, __S2_BSS_Audio_Soundweb_London_Node_TEMPSTRING1_STRING_MAX_LEN );
#define __S2_BSS_Audio_Soundweb_London_Node_SENDSTRING_STRING_MAX_LEN 80
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __SENDSTRING, __S2_BSS_Audio_Soundweb_London_Node_SENDSTRING_STRING_MAX_LEN );
#define __S2_BSS_Audio_Soundweb_London_Node_TEMPSTRING2_STRING_MAX_LEN 80
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __TEMPSTRING2, __S2_BSS_Audio_Soundweb_London_Node_TEMPSTRING2_STRING_MAX_LEN );
#define __S2_BSS_Audio_Soundweb_London_Node_TEMPSTRING3_STRING_MAX_LEN 80
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __TEMPSTRING3, __S2_BSS_Audio_Soundweb_London_Node_TEMPSTRING3_STRING_MAX_LEN );
#define __S2_BSS_Audio_Soundweb_London_Node_RECEIVESTRING_STRING_MAX_LEN 80
CREATE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __RECEIVESTRING, __S2_BSS_Audio_Soundweb_London_Node_RECEIVESTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Audio_Soundweb_London_Node )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __COMRX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __MODULESTX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __NODE$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Audio_Soundweb_London_Node )
{
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __TEMPSTRING1 );
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __SENDSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __TEMPSTRING2 );
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __TEMPSTRING3 );
   DECLARE_STRING_STRUCT( S2_BSS_Audio_Soundweb_London_Node, __RECEIVESTRING );
   unsigned short __XOK1;
   unsigned short __CHECKSUM;
   unsigned short __I;
   unsigned short __XOK2;
   unsigned short __J;
   unsigned short __MARKER1;
   unsigned short __MARKER2;
};



#endif //__S2_BSS_AUDIO_SOUNDWEB_LONDON_NODE_H__

