#ifndef __S2_BSS_SOUNDWEB_LONDON_ROOM_COMBINE_H__
#define __S2_BSS_SOUNDWEB_LONDON_ROOM_COMBINE_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_BSS_Soundweb_London_Room_Combine_ENABLE_FEEDBACK$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Room_Combine_DISABLE_FEEDBACK$_DIG_INPUT 1

#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEMUTE_RM$_DIG_INPUT 2
#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEMUTE_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_MUTE_RM$_DIG_INPUT 10
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_MUTE_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERMUTE_RM$_DIG_INPUT 18
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERMUTE_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_PARTITION$_DIG_INPUT 26
#define __S2_BSS_Soundweb_London_Room_Combine_PARTITION$_ARRAY_LENGTH 8

/*
* ANALOG_INPUT
*/
#define __S2_BSS_Soundweb_London_Room_Combine_CHAN_OFFSET$_ANALOG_INPUT 1


#define __S2_BSS_Soundweb_London_Room_Combine_RX$_BUFFER_INPUT 0
#define __S2_BSS_Soundweb_London_Room_Combine_RX$_BUFFER_MAX_LEN 400
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __RX$, __S2_BSS_Soundweb_London_Room_Combine_RX$_BUFFER_MAX_LEN );

#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEGAIN_RM$_ANALOG_INPUT 2
#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEGAIN_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_GAIN_RM$_ANALOG_INPUT 10
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_GAIN_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERGAIN_RM$_ANALOG_INPUT 18
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERGAIN_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_INPUT_RM$_ANALOG_INPUT 26
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_INPUT_RM$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_GROUP_RM$_ANALOG_INPUT 34
#define __S2_BSS_Soundweb_London_Room_Combine_GROUP_RM$_ARRAY_LENGTH 8

/*
* DIGITAL_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEMUTE_RM_FB$_DIG_OUTPUT 0
#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEMUTE_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_MUTE_RM_FB$_DIG_OUTPUT 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_MUTE_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERMUTE_RM_FB$_DIG_OUTPUT 16
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERMUTE_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_PARTITION_FB$_DIG_OUTPUT 24
#define __S2_BSS_Soundweb_London_Room_Combine_PARTITION_FB$_ARRAY_LENGTH 8

/*
* ANALOG_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Room_Combine_TX$_STRING_OUTPUT 0

#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEGAIN_RM_FB$_ANALOG_OUTPUT 1
#define __S2_BSS_Soundweb_London_Room_Combine_SOURCEGAIN_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_GAIN_RM_FB$_ANALOG_OUTPUT 9
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_GAIN_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERGAIN_RM_FB$_ANALOG_OUTPUT 17
#define __S2_BSS_Soundweb_London_Room_Combine_MASTERGAIN_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_INPUT_RM_FB$_ANALOG_OUTPUT 25
#define __S2_BSS_Soundweb_London_Room_Combine_BGM_INPUT_RM_FB$_ARRAY_LENGTH 8
#define __S2_BSS_Soundweb_London_Room_Combine_GROUP_RM_FB$_ANALOG_OUTPUT 33
#define __S2_BSS_Soundweb_London_Room_Combine_GROUP_RM_FB$_ARRAY_LENGTH 8

/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
#define __S2_BSS_Soundweb_London_Room_Combine_MAX_ROOMS$_INTEGER_PARAMETER 10
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
#define __S2_BSS_Soundweb_London_Room_Combine_OBJECTID$_STRING_PARAMETER 11
#define __S2_BSS_Soundweb_London_Room_Combine_OBJECTID$_PARAM_MAX_LEN 3
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __OBJECTID$, __S2_BSS_Soundweb_London_Room_Combine_OBJECTID$_PARAM_MAX_LEN );


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Room_Combine, __SOURCEGAIN, 8 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Room_Combine, __BGM_GAIN, 8 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Room_Combine, __MASTERGAIN, 8 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Room_Combine, __XOKSOURCEGAIN, 8 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Room_Combine, __XOKBGM_GAIN, 8 );;
CREATE_INTARRAY1D( S2_BSS_Soundweb_London_Room_Combine, __XOKMASTERGAIN, 8 );;


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
#define __S2_BSS_Soundweb_London_Room_Combine_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __RETURNSTRING, __S2_BSS_Soundweb_London_Room_Combine_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Room_Combine_TEMPSTRING_STRING_MAX_LEN 40
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __TEMPSTRING, __S2_BSS_Soundweb_London_Room_Combine_TEMPSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Room_Combine )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __SOURCEMUTE_RM$ );
   DECLARE_IO_ARRAY( __BGM_MUTE_RM$ );
   DECLARE_IO_ARRAY( __MASTERMUTE_RM$ );
   DECLARE_IO_ARRAY( __PARTITION$ );
   DECLARE_IO_ARRAY( __SOURCEMUTE_RM_FB$ );
   DECLARE_IO_ARRAY( __BGM_MUTE_RM_FB$ );
   DECLARE_IO_ARRAY( __MASTERMUTE_RM_FB$ );
   DECLARE_IO_ARRAY( __PARTITION_FB$ );
   DECLARE_IO_ARRAY( __SOURCEGAIN_RM$ );
   DECLARE_IO_ARRAY( __BGM_GAIN_RM$ );
   DECLARE_IO_ARRAY( __MASTERGAIN_RM$ );
   DECLARE_IO_ARRAY( __BGM_INPUT_RM$ );
   DECLARE_IO_ARRAY( __GROUP_RM$ );
   DECLARE_IO_ARRAY( __SOURCEGAIN_RM_FB$ );
   DECLARE_IO_ARRAY( __BGM_GAIN_RM_FB$ );
   DECLARE_IO_ARRAY( __MASTERGAIN_RM_FB$ );
   DECLARE_IO_ARRAY( __BGM_INPUT_RM_FB$ );
   DECLARE_IO_ARRAY( __GROUP_RM_FB$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __RX$ );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __OBJECTID$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Room_Combine )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Room_Combine, __TEMPSTRING );
   unsigned short __OFFSET;
   unsigned short __FEEDBACK;
   unsigned short __STATEVAR;
   unsigned short __SV;
   unsigned short __SV_MOD;
   unsigned short __STATEVARGAIN;
   unsigned short __STATEVARSUB;
   unsigned short __STATEVARUNSUB;
   unsigned short __X;
   unsigned short __RETURNI;
   unsigned short __XOK;
   unsigned short __XOKFEEDBACK;
   unsigned short __I;
   unsigned short __VOLUME;
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Room_Combine, __SOURCEGAIN );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Room_Combine, __BGM_GAIN );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Room_Combine, __MASTERGAIN );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Room_Combine, __XOKSOURCEGAIN );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Room_Combine, __XOKBGM_GAIN );
   DECLARE_INTARRAY( S2_BSS_Soundweb_London_Room_Combine, __XOKMASTERGAIN );
};

DEFINE_WAITEVENT( S2_BSS_Soundweb_London_Room_Combine, __SPLS_TMPVAR__WAITLABEL_0__ );


#endif //__S2_BSS_SOUNDWEB_LONDON_ROOM_COMBINE_H__

