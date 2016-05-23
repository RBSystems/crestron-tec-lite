#ifndef __S2_BSS_SOUNDWEB_LONDON_DELAY_H__
#define __S2_BSS_SOUNDWEB_LONDON_DELAY_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Delay_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Delay_UNSUBSCRIBE$_DIG_INPUT 1


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Delay_DELAY$_ANALOG_INPUT 0


#define __S2_BSS_Soundweb_London_Delay_RX$_BUFFER_INPUT 1
#define __S2_BSS_Soundweb_London_Delay_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __RX$, __S2_BSS_Soundweb_London_Delay_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Delay_DELAY_FB$_ANALOG_OUTPUT 0

#define __S2_BSS_Soundweb_London_Delay_TX$_STRING_OUTPUT 1


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
#define __S2_BSS_Soundweb_London_Delay_OBJECTID$_STRING_PARAMETER 10
#define __S2_BSS_Soundweb_London_Delay_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __OBJECTID$, __S2_BSS_Soundweb_London_Delay_OBJECTID$_PARAM_MAX_LEN );


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
#define __S2_BSS_Soundweb_London_Delay_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __TEMPSTRING, __S2_BSS_Soundweb_London_Delay_TEMPSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Delay_DELAYSTRING_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __DELAYSTRING, __S2_BSS_Soundweb_London_Delay_DELAYSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Delay_DELAYSENDSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __DELAYSENDSTRING, __S2_BSS_Soundweb_London_Delay_DELAYSENDSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Delay )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Delay )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __TEMPSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __DELAYSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Delay, __DELAYSENDSTRING );
   unsigned short __XOK;
   unsigned short __XOKSUBSCRIBE;
   unsigned short __DELAY1;
   unsigned short __DELAY2;
   unsigned short __DELAY3;
   unsigned short __VALUE_FB;
   unsigned short __DECIMALVALUE_FB;
   unsigned short __DELAY_INT;
   unsigned long __DELAYVALUE;
   unsigned long __DELAYVALUE_FB;
};



#endif //__S2_BSS_SOUNDWEB_LONDON_DELAY_H__

