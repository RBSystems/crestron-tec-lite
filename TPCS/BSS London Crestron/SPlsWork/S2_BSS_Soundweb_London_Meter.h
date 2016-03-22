#ifndef __S2_BSS_SOUNDWEB_LONDON_METER_H__
#define __S2_BSS_SOUNDWEB_LONDON_METER_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Meter_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Meter_UNSUBSCRIBE$_DIG_INPUT 1


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Meter_ATTACK$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_Meter_RELEASE$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_Meter_REFERENCE$_ANALOG_INPUT 2


#define __S2_BSS_Soundweb_London_Meter_RX$_BUFFER_INPUT 3
#define __S2_BSS_Soundweb_London_Meter_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __RX$, __S2_BSS_Soundweb_London_Meter_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Meter_ATTACK_FB$_ANALOG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Meter_RELEASE_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Meter_REFERENCE_FB$_ANALOG_OUTPUT 2

#define __S2_BSS_Soundweb_London_Meter_TX$_STRING_OUTPUT 3


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
#define __S2_BSS_Soundweb_London_Meter_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Meter_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __OBJECTID$, __S2_BSS_Soundweb_London_Meter_OBJECTID$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Meter_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __TEMPSTRING, __S2_BSS_Soundweb_London_Meter_TEMPSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Meter_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __RETURNSTRING, __S2_BSS_Soundweb_London_Meter_RETURNSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Meter )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Meter )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __TEMPSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Meter, __RETURNSTRING );
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __VOLUME;
   unsigned short __RETURNI;
   unsigned short __SUBSCRIBE;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Meter, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_METER_H__

