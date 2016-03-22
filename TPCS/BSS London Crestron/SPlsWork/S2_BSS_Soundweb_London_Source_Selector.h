#ifndef __S2_BSS_SOUNDWEB_LONDON_SOURCE_SELECTOR_H__
#define __S2_BSS_SOUNDWEB_LONDON_SOURCE_SELECTOR_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Source_Selector_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Source_Selector_UNSUBSCRIBE$_DIG_INPUT 1


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Source_Selector_INPUT$_ANALOG_INPUT 0


#define __S2_BSS_Soundweb_London_Source_Selector_RX$_BUFFER_INPUT 1
#define __S2_BSS_Soundweb_London_Source_Selector_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Selector, __RX$, __S2_BSS_Soundweb_London_Source_Selector_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Source_Selector_INPUT_FB$_ANALOG_OUTPUT 0

#define __S2_BSS_Soundweb_London_Source_Selector_TX$_STRING_OUTPUT 1


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
#define __S2_BSS_Soundweb_London_Source_Selector_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Source_Selector_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Selector, __OBJECTID$, __S2_BSS_Soundweb_London_Source_Selector_OBJECTID$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Source_Selector_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Selector, __TEMPSTRING, __S2_BSS_Soundweb_London_Source_Selector_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Source_Selector )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Selector, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Selector, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Source_Selector )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Source_Selector, __TEMPSTRING );
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __I;
   unsigned short __X;
   unsigned short __STATEVAR;
   unsigned short __SUBSCRIBE;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Source_Selector, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_SOURCE_SELECTOR_H__

