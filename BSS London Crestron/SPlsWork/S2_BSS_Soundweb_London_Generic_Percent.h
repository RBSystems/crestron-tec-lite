#ifndef __S2_BSS_SOUNDWEB_LONDON_GENERIC_PERCENT_H__
#define __S2_BSS_SOUNDWEB_LONDON_GENERIC_PERCENT_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Generic_Percent_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Generic_Percent_UNSUBSCRIBE$_DIG_INPUT 1


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Generic_Percent_VALUE$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_Generic_Percent_STATEVARIABLE$_ANALOG_INPUT 2

#define __S2_BSS_Soundweb_London_Generic_Percent_OBJECTID$_STRING_INPUT 1
#define __S2_BSS_Soundweb_London_Generic_Percent_OBJECTID$_STRING_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __OBJECTID$, __S2_BSS_Soundweb_London_Generic_Percent_OBJECTID$_STRING_MAX_LEN );

#define __S2_BSS_Soundweb_London_Generic_Percent_RX$_BUFFER_INPUT 3
#define __S2_BSS_Soundweb_London_Generic_Percent_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __RX$, __S2_BSS_Soundweb_London_Generic_Percent_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Generic_Percent_VALUE_FB$_ANALOG_OUTPUT 0

#define __S2_BSS_Soundweb_London_Generic_Percent_TX$_STRING_OUTPUT 1


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
#define __S2_BSS_Soundweb_London_Generic_Percent_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __RETURNSTRING, __S2_BSS_Soundweb_London_Generic_Percent_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Generic_Percent_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __TEMPSTRING, __S2_BSS_Soundweb_London_Generic_Percent_TEMPSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Generic_Percent_STATEVARIABLE_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __STATEVARIABLE, __S2_BSS_Soundweb_London_Generic_Percent_STATEVARIABLE_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Generic_Percent )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __OBJECTID$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __RX$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Generic_Percent )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __TEMPSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Generic_Percent, __STATEVARIABLE );
   unsigned short __I;
   unsigned short __VOLUME;
   unsigned short __RETURNI;
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __VOLUMEINPUT;
   unsigned short __XOKGAIN;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Generic_Percent, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_GENERIC_PERCENT_H__

