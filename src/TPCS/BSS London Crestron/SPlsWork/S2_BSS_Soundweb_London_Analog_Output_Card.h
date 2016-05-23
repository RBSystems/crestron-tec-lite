#ifndef __S2_BSS_SOUNDWEB_LONDON_ANALOG_OUTPUT_CARD_H__
#define __S2_BSS_SOUNDWEB_LONDON_ANALOG_OUTPUT_CARD_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Output_Card_SUBSCRIBE$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Analog_Output_Card_UNSUBSCRIBE$_DIG_INPUT 1
#define __S2_BSS_Soundweb_London_Analog_Output_Card_METER_SUBSCRIBE$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_MUTEON$_DIG_INPUT 3
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_MUTEOFF$_DIG_INPUT 4
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_MUTETOGGLE$_DIG_INPUT 5
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_MUTEON$_DIG_INPUT 6
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_MUTEOFF$_DIG_INPUT 7
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_MUTETOGGLE$_DIG_INPUT 8
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_MUTEON$_DIG_INPUT 9
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_MUTEOFF$_DIG_INPUT 10
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_MUTETOGGLE$_DIG_INPUT 11
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_MUTEON$_DIG_INPUT 12
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_MUTEOFF$_DIG_INPUT 13
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_MUTETOGGLE$_DIG_INPUT 14


/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_REFERENCE$_ANALOG_INPUT 0
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_ATTACK$_ANALOG_INPUT 1
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_RELEASE$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_REFERENCE$_ANALOG_INPUT 3
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_ATTACK$_ANALOG_INPUT 4
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_RELEASE$_ANALOG_INPUT 5
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_REFERENCE$_ANALOG_INPUT 6
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_ATTACK$_ANALOG_INPUT 7
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_RELEASE$_ANALOG_INPUT 8
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_REFERENCE$_ANALOG_INPUT 9
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_ATTACK$_ANALOG_INPUT 10
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_RELEASE$_ANALOG_INPUT 11


#define __S2_BSS_Soundweb_London_Analog_Output_Card_RX$_BUFFER_INPUT 12
#define __S2_BSS_Soundweb_London_Analog_Output_Card_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card, __RX$, __S2_BSS_Soundweb_London_Analog_Output_Card_RX$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_MUTE_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_MUTE_FB$_DIG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_MUTE_FB$_DIG_OUTPUT 2
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_MUTE_FB$_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_METER_FB$_ANALOG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_REFERENCE_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_ATTACK_FB$_ANALOG_OUTPUT 2
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_1_RELEASE_FB$_ANALOG_OUTPUT 3
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_METER_FB$_ANALOG_OUTPUT 4
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_REFERENCE_FB$_ANALOG_OUTPUT 5
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_ATTACK_FB$_ANALOG_OUTPUT 6
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_2_RELEASE_FB$_ANALOG_OUTPUT 7
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_METER_FB$_ANALOG_OUTPUT 8
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_REFERENCE_FB$_ANALOG_OUTPUT 9
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_ATTACK_FB$_ANALOG_OUTPUT 10
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_3_RELEASE_FB$_ANALOG_OUTPUT 11
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_METER_FB$_ANALOG_OUTPUT 12
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_REFERENCE_FB$_ANALOG_OUTPUT 13
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_ATTACK_FB$_ANALOG_OUTPUT 14
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CHANNEL_4_RELEASE_FB$_ANALOG_OUTPUT 15

#define __S2_BSS_Soundweb_London_Analog_Output_Card_TX$_STRING_OUTPUT 16


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Analog_Output_Card_METERRATE$_INTEGER_PARAMETER 10
#define __S2_BSS_Soundweb_London_Analog_Output_Card_CARD$_INTEGER_PARAMETER 11
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
#define __S2_BSS_Soundweb_London_Analog_Output_Card_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card, __TEMPSTRING, __S2_BSS_Soundweb_London_Analog_Output_Card_TEMPSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Analog_Output_Card_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card, __RETURNSTRING, __S2_BSS_Soundweb_London_Analog_Output_Card_RETURNSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card, __RX$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card, __TEMPSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Analog_Output_Card, __RETURNSTRING );
   unsigned short __XOK;
   unsigned short __XSUBSCRIBE;
   unsigned short __SUBSCRIBE;
   unsigned short __METER_SUBSCRIBE;
   unsigned short __VOLUME;
   unsigned short __RETURNI;
   unsigned short __I;
   unsigned short __XVALUE;
   unsigned short __STATEVARVALUE;
   unsigned short __STATEVARPHANTOM;
   unsigned short __STATEVARRECEIVE;
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Analog_Output_Card, __SPLS_TMPVAR__WAITLABEL_0__ );
DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Analog_Output_Card, __SPLS_TMPVAR__WAITLABEL_1__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_ANALOG_OUTPUT_CARD_H__

