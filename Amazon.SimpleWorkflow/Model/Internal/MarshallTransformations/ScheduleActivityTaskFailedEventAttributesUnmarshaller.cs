/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */ 
    using System;
    using System.Collections.Generic; 
    using Amazon.SimpleWorkflow.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ScheduleActivityTaskFailedEventAttributesUnmarshaller 
      /// </summary> 
      internal class ScheduleActivityTaskFailedEventAttributesUnmarshaller : IUnmarshaller<ScheduleActivityTaskFailedEventAttributes, UnmarshallerContext>, IUnmarshaller<ScheduleActivityTaskFailedEventAttributes, JsonUnmarshallerContext> 
      { 
        ScheduleActivityTaskFailedEventAttributes IUnmarshaller<ScheduleActivityTaskFailedEventAttributes, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ScheduleActivityTaskFailedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          ScheduleActivityTaskFailedEventAttributes scheduleActivityTaskFailedEventAttributes = new ScheduleActivityTaskFailedEventAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("ActivityType", targetDepth)) 
              {
                scheduleActivityTaskFailedEventAttributes.ActivityType = ActivityTypeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ActivityId", targetDepth)) 
              {
                scheduleActivityTaskFailedEventAttributes.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Cause", targetDepth)) 
              {
                scheduleActivityTaskFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth)) 
              {
                scheduleActivityTaskFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return scheduleActivityTaskFailedEventAttributes; 
            } 
          } 
          return scheduleActivityTaskFailedEventAttributes; 
        } 
        
        private static ScheduleActivityTaskFailedEventAttributesUnmarshaller instance; 
        public static ScheduleActivityTaskFailedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new ScheduleActivityTaskFailedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  